using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StackTool
{
    public partial class Form1 : Form
    {
        private string pathToReelData = @"ReelData.csv";                    //program will look for this file at startup and autoload reel data if available
        private string pathToComponentData = @"";

        private List<Feeder> reelStack = new List<Feeder>();                //a list of the feeders available on the machine
        private List<Component> parts = new List<Component>();              //a list of all the components in the loaded .pos file
        private List<Component> uniqueParts = new List<Component>();        //a list of all the unique components in the .pos file
        public Form1()
        {
            InitializeComponent();
            //look for a file called 'ReelData.csv' upon starting up. if file exists open and read
            if(File.Exists(pathToReelData))
            {
                //file found! start loading the data 
                reelStatusLabel.Text = "Reel data found!";
                loadFeeder();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openReelDataDialog.ShowDialog()==DialogResult.OK)
            {
                pathToReelData = openReelDataDialog.InitialDirectory + openReelDataDialog.FileName;
                reelStatusLabel.Text = "Reel data found!";
                //file found! start loading reels
                loadFeeder();
            }
        }

        /*
         * loadFeeder takes the ReelData.csv file and populates the feederlist
         */
        private void loadFeeder()
        {
            string line;
            StreamReader s = new StreamReader(pathToReelData);

            //first line is the header line
            line = s.ReadLine();
            while(( line = s.ReadLine()) != null)
            {
                //now we got a line with reel parameters
                string[] parameters = line.Split(',');  //split into array

                //now create an instance of the reel in the reel stack
                ushort i;
                if(ushort.TryParse(parameters[1],out i))
                    reelStack.Add(new Feeder { feederID = ushort.Parse(parameters[1]) } );
                else
                    reelStack.Add(new Feeder { feederID = 0 });
                //now we have a feeder to enter the rest of the information in to..
                reelStack[reelStack.Count-1].component = parameters[2]; //parameter 2 is value, package and maybe voltage..

                //try to find out the package and value for the feeder
                if (reelStack[reelStack.Count - 1].component.Length > 0)
                {
                    reelStack[reelStack.Count - 1].value = reelStack[reelStack.Count - 1].component.Split('-')[0];
                    reelStack[reelStack.Count - 1].package = reelStack[reelStack.Count - 1].component.Split('-')[1].Split(' ')[0];
                }

                //next we just parse all the parameters from the .csv file. Take care to handle '.' and ',' situations...
                float.TryParse(parameters[3], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].xOffset);
                float.TryParse(parameters[4], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].yOffset);
                float.TryParse(parameters[5], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].height);
                short.TryParse(parameters[6], out reelStack[reelStack.Count - 1].speed);
                short.TryParse(parameters[7], out reelStack[reelStack.Count - 1].head);
                float.TryParse(parameters[8], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].tapeAngle);
                short.TryParse(parameters[9], out reelStack[reelStack.Count - 1].feedSpacing);
                if (parameters[10].ToString() == "Y")
                    reelStack[reelStack.Count - 1].placeComponent = true;
                if (parameters[11].ToString() == "Y")
                    reelStack[reelStack.Count - 1].checkVacuum = true;
                if (parameters[12].ToString() == "Y")
                    reelStack[reelStack.Count - 1].useVision = true;
                float.TryParse(parameters[13], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].xCorrection);
                float.TryParse(parameters[14], NumberStyles.Any, CultureInfo.InvariantCulture, out reelStack[reelStack.Count - 1].yCorrection);

                reelStack[reelStack.Count - 1].alias = parameters[15];
                reelStack[reelStack.Count - 1].orderNumber = parameters[16];
                reelStack[reelStack.Count - 1].supplier = parameters[17];
                reelStack[reelStack.Count - 1].notes = parameters[18];

                //populate the main info for the stack list here - feeder ID, component value and pacakge. 
                machineStack.Rows.Add(new string[] { reelStack[reelStack.Count - 1].feederID.ToString(), reelStack[reelStack.Count - 1].value, reelStack[reelStack.Count - 1].package });
            }
            s.Close();
        }

        /*
         * this is called every time the user clicks on a row in the stack list. Update the groupbox accordingly here
         */
        private void machineStack_SelectionChanged(object sender, EventArgs e)
        {
            if(machineStack.SelectedCells.Count>0)
            {
                int selectedRowIndex = machineStack.SelectedCells[0].RowIndex;  //get the currently selected ID
                Feeder selectedFeeder = reelStack[selectedRowIndex];    //create a feeder copy of the selected one so we can load the data from that

                feederHeight.Text = selectedFeeder.height.ToString();
                feederSpeed.Text = selectedFeeder.speed.ToString();
                feederHead.Text = selectedFeeder.head.ToString();
                feederOffsetX.Text = selectedFeeder.xOffset.ToString();
                feederOffsetY.Text = selectedFeeder.yOffset.ToString();
                feederCorrectionX.Text = selectedFeeder.xCorrection.ToString();
                feederCorrectionY.Text = selectedFeeder.yCorrection.ToString();
                feederTapeAngle.Text = selectedFeeder.tapeAngle.ToString();
                feederFeedSpacing.Text = selectedFeeder.feedSpacing.ToString();
                if (selectedFeeder.placeComponent)
                    feederPlaceComponent.Checked = true;
                else
                    feederPlaceComponent.Checked = false;
                if (selectedFeeder.checkVacuum)
                    feederCheckVacuum.Checked = true;
                else
                    feederCheckVacuum.Checked = false;
                if (selectedFeeder.useVision)
                    feederUseVision.Checked = true;
                else
                    feederUseVision.Checked = false;
                feederAliases.Text = selectedFeeder.alias.Replace(":", "\r\n");
                feederSupplier.Text = selectedFeeder.supplier;
                feederOrderNumber.Text = selectedFeeder.orderNumber;
                feederComponentName.Text = selectedFeeder.component;
            }
        }
        
        //The next section of methods allow for the drag/drop reorganization of the reels in the stack (feeder list)
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void machineStack_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if(dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X,e.Y))
                {
                    DragDropEffects dropEffect = machineStack.DoDragDrop(
                        machineStack.Rows[rowIndexFromMouseDown],
                        DragDropEffects.Move);
                }
            }
        }

        private void machineStack_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = machineStack.HitTest(e.X, e.Y).RowIndex;
            if(rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),e.Y - (dragSize.Height / 2)),dragSize);
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void machineStack_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void machineStack_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = machineStack.PointToClient(new Point(e.X, e.Y));

            rowIndexOfItemUnderMouseToDrop = machineStack.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if(e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                if(rowIndexOfItemUnderMouseToDrop < 0)
                {
                    return;
                }
                machineStack.Rows.RemoveAt(rowIndexFromMouseDown);
                machineStack.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

                Feeder oldIndex = reelStack[rowIndexFromMouseDown]; //make a copy of the feeder to be moved
                reelStack.RemoveAt(rowIndexFromMouseDown);  //remove the item
                reelStack.Insert(rowIndexOfItemUnderMouseToDrop,oldIndex);   //insert the old list on the new position


                //lastly we need to change the feeder ID numbers to reflect the new order
                for(int i = 0;i<machineStack.Rows.Count;i++)
                {
                    machineStack.Rows[i].Cells[0].Value = i+1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //now we want to write a new file with the current values available in the machineStack.
            string header = "Tape Size,Feeder Number,Component,XOffset,YOffset,Height,Speed,Head,Relative Tape Angle,Feed Spacing,Place Component,Check Vacuum,Use Vision,Centroid Correction X,Centroid Correction Y,Aliases,Order Number,Supplier,Notes";
            StreamWriter s = new StreamWriter(pathToReelData);
            s.WriteLine(header);
            s.Close();
        }

        /*
         * load the .pos file into a list
         */
        private void button4_Click(object sender, EventArgs e)
        {
            int totalParts = 0; //counter for the total number of parts in the loaded file
            if (openComponentDataDialog.ShowDialog() == DialogResult.OK)    //locate the file
            {
                pathToComponentData = openComponentDataDialog.InitialDirectory + openComponentDataDialog.FileName;
                componentStatusLabel.Text = "Component data found!";

                string line;
                StreamReader s = new StreamReader(pathToComponentData);
                while ((line = s.ReadLine()) != null)
                {
                    if (line.StartsWith("#"))   //ignore all comments
                    {
                    }
                    else
                    {
                        line = Regex.Replace(line, @"(\s)\s+", "$1");   //remove all but one whitespace from the line
                        string[] parameters = line.Split(' ');
                        parts.Add(new Component { designator=parameters[0], value=parameters[1], package=parameters[2] });
                        decimal.TryParse(parameters[3], NumberStyles.Any, CultureInfo.InvariantCulture, out parts[parts.Count - 1].posX);
                        decimal.TryParse(parameters[4], NumberStyles.Any, CultureInfo.InvariantCulture, out parts[parts.Count - 1].posY);
                        decimal.TryParse(parameters[5], NumberStyles.Any, CultureInfo.InvariantCulture, out parts[parts.Count - 1].rotation);

                        totalParts++;
                    }
                }
                totalPartsCountLabel.Text = "Loaded " + totalParts + " parts";
                findUniqueParts();
                matchParts();   //with the unique parts found try to match them with the components in the stack
            }
        }

        /*
         * find out how many unique parts exist. Value and package must match!
         */
        private void findUniqueParts()
        {
            //first we create the first component as a unique component and add it to the list of components of same type
            uniqueParts.Add(parts[0]);
            uniqueParts[0].ofSameType.Add(parts[0]);

            for (int i = 1; i < parts.Count; i++)
            {
                for (int j = 0; j < uniqueParts.Count; j++)
                {
                    if (string.Equals(parts[i].value, uniqueParts[j].value) && string.Equals(parts[i].package, uniqueParts[j].package))
                    {
                        uniqueParts[j].ofSameType.Add(parts[i]);
                        parts[i].isPlaced = true;
                        break;
                    }
                }
                //if part is still not placed under a unique component it needs to be added as a new entry
                if (!parts[i].isPlaced)
                {
                    uniqueParts.Add(parts[i]);
                    uniqueParts[uniqueParts.Count - 1].ofSameType.Add(parts[i]);
                }
            }
            uniquePartsLabel.Text = "Total Unique parts: " + uniqueParts.Count.ToString();

            foreach(Component c in uniqueParts)
            {
                uniquePartsDataView.Rows.Add(c.ofSameType.Count, c.value, c.package);
                //textBox1.AppendText("<"+c.ofSameType.Count+"> - "+c.value + ", " + c.package+"\r\n");
            }
        }
        private void matchParts()
        {
            foreach(Component c in uniqueParts) //we want to try and match the unique parts with the items in the reel stack
            {
                if (c.value != "N/A")
                {
                    //Console.WriteLine("Component Start: " +c.value);
                    foreach (Feeder reel in reelStack)  //we can go through all the reels in our search for the matching part
                    {
                        Console.Write(c.designator + ": Trying to match: " + reel.component.Split('-')[0] + " with: " + c.value);

                        if (reel.component.Length > 1)     //no need to look in empty feeders
                        {

                            //We start by looking at the values of the components
                            if (c.value.Equals(reel.component.Split('-')[0]))    //the values are matching. add to the list
                            {
                                Console.WriteLine(" - MATCH");
                                c.matchingFeederID = reel.feederID; //store the feederID that was matched to this unique component
                                matchingParts.Rows.Add(c.value, reel.component, "Auto");
                                reel.usedInDesign = true;
                                c.isPlaced = true;
                                break;
                            }
                            else        // no match is found, try the aliases
                            {
                                string[] aliases = reel.alias.Split(':');
                                if (aliases.Length > 0)    //if there are aliases to look through
                                {
                                    for (int i = 0; i < aliases.Length; i++)
                                    {
                                        //Console.Write(aliases[i].Split('-')[0]);
                                        if (c.value.Equals(aliases[i].Split('-')[0]))
                                        {
                                            c.matchingFeederID = reel.feederID; //store the feederID that was matched to this unique component
                                            matchingParts.Rows.Add(c.value, reel.component, "Auto");
                                            reel.usedInDesign = true;
                                            c.isPlaced = true;
                                            break;
                                        }
                                    }
                                    Console.WriteLine("");
                                }
                            }


                        }
                    }
                }
                //if the matchingFeederID is still not set we haven't matched the component at all
                if(c.matchingFeederID<0)
                {
                    matchingParts.Rows.Add(c.value, "No Match", "No Mount");
                }
            }
        }

        private void generateDPVFileButton_Click(object sender, EventArgs e)
        {
            // first we change the unique parts to reflect the overrides requests
            for (int i=0;i<uniqueParts.Count;i++)
            {
                
                if(matchingParts.Rows[i].Cells[2].Value.ToString()=="No Mount")
                {
                    uniqueParts[i].isoverridden = true;
                }
                if (matchingParts.Rows[i].Cells[2].Value.ToString() == "Auto")
                {
                    uniqueParts[i].isoverridden = false;
                }
            }

            string fileName = openComponentDataDialog.SafeFileName.Split('.')[0];
            dpvGenerator gen = new dpvGenerator(fileName+".dpv", reelStack, uniqueParts);
            gen.generateData(openComponentDataDialog.SafeFileName.Split('.')[0]);
        }

        private void overrideTrayRadio_CheckedChanged(object sender, EventArgs e)
        {
            overrideTrayCombo.Enabled = true;
            overrideReelCombo.Enabled = false;
            updateOverrides();
        }

        private void overrideAutoRadio_CheckedChanged(object sender, EventArgs e)
        {
            // no changes should be allowed - disable all manual controls!
            overrideReelCombo.Enabled = false;
            overrideTrayCombo.Enabled = false;
            updateOverrides();
        }
        private void noMountRadio_CheckedChanged(object sender, EventArgs e)
        {
            overrideReelCombo.Enabled = false;
            overrideTrayCombo.Enabled = false;
            updateOverrides();
        }

        private void overrideManualRadio_CheckedChanged(object sender, EventArgs e)
        {
            overrideReelCombo.Enabled = true;
            overrideTrayCombo.Enabled = false;
            updateOverrides();
        }

        int uniquePartSelected = -1;
        private void MatchingParts_SelectionChanged(object sender, EventArgs e)
        {
            uniquePartSelected = matchingParts.SelectedCells[0].RowIndex;
            label18.Text = uniquePartSelected.ToString();
        }

        private void updateOverrides()
        {
            if(uniquePartSelected>-1)   //a row have been selected
            {
                if(overrideAutoRadio.Checked)   //auto is selected
                {
                    matchingParts.Rows[uniquePartSelected].Cells[2].Value = "Auto";
                }
                if(overrideNoMountRadio.Checked)
                {
                    matchingParts.Rows[uniquePartSelected].Cells[2].Value = "No Mount";
                }

                if(overrideManualRadio.Checked)
                {
                    matchingParts.Rows[uniquePartSelected].Cells[2].Value = "Manual reel";
                }
                if(overrideTrayRadio.Checked)
                {
                    matchingParts.Rows[uniquePartSelected].Cells[2].Value = overrideTrayCombo.SelectedItem;
                }
            }
        }

        private void overrideTrayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOverrides();
        }


    }
}
