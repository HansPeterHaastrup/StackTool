using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StackTool
{
    class dpvGenerator
    {
        private string _pathToFile =@"";
        private List<Feeder> _reelStack;
        private List<Component> _uniqueParts;
        public dpvGenerator(string pathToFile, List<Feeder> reelStack, List<Component> uniqueParts)
        {
            _pathToFile = pathToFile;
            _reelStack = reelStack;
            _uniqueParts = uniqueParts;
        }
        public void generateData(string inputFile)
        {
            //generate header
            string header = "separated";
            StreamWriter s = new StreamWriter(_pathToFile);
            s.WriteLine(header);
            s.WriteLine("FILE," + inputFile + ".dpv");
            s.WriteLine("PCBFILE," + inputFile + ".pos");
            string date = DateTime.Today.ToString();
            s.WriteLine("DATE," + date.Split(' ')[0]);
            s.WriteLine("TIME," + date.Split(' ')[1]);
            s.WriteLine("PANELYPE,0");
            s.WriteLine("");

            //generate list of feeders or 'stations'
            s.WriteLine("Table,No.,ID,DeltX,DeltY,FeedRates,Note,Height,Speed,Status,SizeX,SizeY,HeightTake,DelayTake");
            int stationID = 0;
            foreach (Feeder reel in _reelStack)
            {
                //only if the reel is used in the design
                if(reel.usedInDesign)
                {
                    s.Write("Station," + stationID + ",");
                    s.Write(reel.feederID + ",");
                    s.Write(reel.xOffset + ",");
                    s.Write(reel.yOffset + ",");
                    s.Write(reel.feedSpacing + ",");
                    s.Write(reel.component + ",");
                    s.Write(reel.height.ToString().Replace(',','.') + ",");
                    s.Write(reel.speed + ",");
                    s.Write("6" + ",");
                    s.Write("0" + ",");
                    s.Write("0" + ",");
                    s.Write("0" + ",");
                    s.Write("0");
                    s.WriteLine("");
                    stationID++;
                }
            }
            s.WriteLine("");

            //generate table 'Panel_Coord'
            s.WriteLine("Table,No.,ID,DeltX,DeltY");
            s.WriteLine("Panel_Coord,0,1,0,0");
            s.WriteLine("");

            //generate table with all components in them
            s.WriteLine("Table,No.,ID,PHead,STNo.,DeltX,DeltY,Angle,Height,Skip,Speed,Explain,Note,Delay");
            int componentID = 0;
            foreach(Component uc in _uniqueParts)
            {
                if (uc.isPlaced && !uc.isoverridden)
                {
                    foreach (Component c in uc.ofSameType)
                    {
                        s.Write("EComponent,");
                        s.Write(componentID + ",");
                        s.Write((componentID + 1) + ",");
                        s.Write(_reelStack[uc.matchingFeederID].head + ",");
                        s.Write(_reelStack[uc.matchingFeederID].feederID + ",");
                        s.Write(c.posX.ToString().Replace(',', '.') + ",");
                        s.Write(c.posY.ToString().Replace(',', '.') + ",");
                        s.Write(c.rotation.ToString().Replace(',', '.') + ",");
                        s.Write("0" + ","); //height
                        s.Write("6" + ","); //skip
                        s.Write(_reelStack[uc.matchingFeederID].speed + ",");
                        s.Write(c.designator + ",");
                        s.Write(_reelStack[uc.matchingFeederID].component + ",");
                        s.Write("0" + ","); //delay
                        s.WriteLine("");
                        componentID++;
                    }
                }
            }

            s.WriteLine("");
            s.WriteLine("Table,No.,ID,CenterX,CenterY,IntervalX,IntervalY,NumX,NumY,Start");
            s.WriteLine("");
            s.WriteLine("Table,No.,nType,nAlg,nFinished");
            s.WriteLine("PcbCalib,0,1,0,0");
            s.WriteLine("");
            s.WriteLine("Table,No.,ID,offsetX,offsetY,Note");

            //insert fiducial points here
            foreach (Component uc in _uniqueParts)  //find the fiducial parts
            {
                if (!uc.isPlaced)   //only look in non-placed parts
                {
                    if(uc.value=="Fiducial")
                    {
                        componentID = 0;
                        foreach (Component c in uc.ofSameType)
                        {
                            s.Write("CalibPoint,");
                            s.Write(componentID + ",0,");
                            s.Write(c.posX.ToString().Replace(',', '.') + ",");
                            s.Write(c.posY.ToString().Replace(',', '.') + ",");
                            s.WriteLine("Mark"+(componentID+1));
                        }
                        break;  //stop - we have placed our calibration points now.
                    }
                    
                }
            }

            s.WriteLine("");
            s.WriteLine("Table,No.,DeltX,DeltY,AlphaX,AlphaY,BetaX,BetaY,DeltaAngle");
            s.WriteLine("CalibFator,0,0,0,0,0,1,1,0");
            s.WriteLine("");

            s.Close();
        }


    }
}
