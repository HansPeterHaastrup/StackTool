namespace StackTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openReelDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.reelStatusLabel = new System.Windows.Forms.Label();
            this.machineStack = new System.Windows.Forms.DataGridView();
            this.feederID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feederInfoGroup = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.feederNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.feederAliases = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.feederSupplier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.feederOrderNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.feederComponentName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.feederHead = new System.Windows.Forms.TextBox();
            this.feederSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feederHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.feederFeedSpacing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.feederTapeAngle = new System.Windows.Forms.TextBox();
            this.feederUseVision = new System.Windows.Forms.CheckBox();
            this.feederCheckVacuum = new System.Windows.Forms.CheckBox();
            this.feederPlaceComponent = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.feederCorrectionY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.feederCorrectionX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feederOffsetY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.feederOffsetX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feederIDLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uniquePartsDataView = new System.Windows.Forms.DataGridView();
            this.partsUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniquePartsLabel = new System.Windows.Forms.Label();
            this.totalPartsCountLabel = new System.Windows.Forms.Label();
            this.componentStatusLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.generateDPVFileButton = new System.Windows.Forms.Button();
            this.MatchingParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openComponentDataDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.machineStack)).BeginInit();
            this.feederInfoGroup.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniquePartsDataView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchingParts)).BeginInit();
            this.SuspendLayout();
            // 
            // openReelDataDialog
            // 
            this.openReelDataDialog.Filter = "Reel Data|ReelData.csv";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Reel Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reelStatusLabel
            // 
            this.reelStatusLabel.AutoSize = true;
            this.reelStatusLabel.Location = new System.Drawing.Point(208, 11);
            this.reelStatusLabel.Name = "reelStatusLabel";
            this.reelStatusLabel.Size = new System.Drawing.Size(109, 13);
            this.reelStatusLabel.TabIndex = 1;
            this.reelStatusLabel.Text = "Reel data not loaded!";
            // 
            // machineStack
            // 
            this.machineStack.AllowDrop = true;
            this.machineStack.AllowUserToAddRows = false;
            this.machineStack.AllowUserToDeleteRows = false;
            this.machineStack.AllowUserToResizeColumns = false;
            this.machineStack.AllowUserToResizeRows = false;
            this.machineStack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.machineStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feederID,
            this.component});
            this.machineStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.machineStack.Location = new System.Drawing.Point(9, 35);
            this.machineStack.MultiSelect = false;
            this.machineStack.Name = "machineStack";
            this.machineStack.ReadOnly = true;
            this.machineStack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.machineStack.RowTemplate.ReadOnly = true;
            this.machineStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.machineStack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.machineStack.ShowEditingIcon = false;
            this.machineStack.Size = new System.Drawing.Size(273, 705);
            this.machineStack.TabIndex = 2;
            this.machineStack.SelectionChanged += new System.EventHandler(this.machineStack_SelectionChanged);
            this.machineStack.DragDrop += new System.Windows.Forms.DragEventHandler(this.machineStack_DragDrop);
            this.machineStack.DragOver += new System.Windows.Forms.DragEventHandler(this.machineStack_DragOver);
            this.machineStack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.machineStack_MouseDown);
            this.machineStack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.machineStack_MouseMove);
            // 
            // feederID
            // 
            this.feederID.HeaderText = "Feeder ID";
            this.feederID.Name = "feederID";
            this.feederID.ReadOnly = true;
            this.feederID.Width = 79;
            // 
            // component
            // 
            this.component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.component.HeaderText = "Component";
            this.component.Name = "component";
            this.component.ReadOnly = true;
            this.component.Width = 150;
            // 
            // feederInfoGroup
            // 
            this.feederInfoGroup.Controls.Add(this.groupBox5);
            this.feederInfoGroup.Controls.Add(this.groupBox4);
            this.feederInfoGroup.Controls.Add(this.groupBox3);
            this.feederInfoGroup.Controls.Add(this.groupBox2);
            this.feederInfoGroup.Controls.Add(this.groupBox1);
            this.feederInfoGroup.Controls.Add(this.feederIDLabel);
            this.feederInfoGroup.Enabled = false;
            this.feederInfoGroup.Location = new System.Drawing.Point(288, 35);
            this.feederInfoGroup.Name = "feederInfoGroup";
            this.feederInfoGroup.Size = new System.Drawing.Size(361, 426);
            this.feederInfoGroup.TabIndex = 3;
            this.feederInfoGroup.TabStop = false;
            this.feederInfoGroup.Text = "Feeder Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.feederNotes);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.feederAliases);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.feederSupplier);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.feederOrderNumber);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.feederComponentName);
            this.groupBox5.Location = new System.Drawing.Point(7, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 178);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Misc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Notes";
            // 
            // feederNotes
            // 
            this.feederNotes.Location = new System.Drawing.Point(186, 71);
            this.feederNotes.Multiline = true;
            this.feederNotes.Name = "feederNotes";
            this.feederNotes.Size = new System.Drawing.Size(148, 101);
            this.feederNotes.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Aliases (One per line)";
            // 
            // feederAliases
            // 
            this.feederAliases.Location = new System.Drawing.Point(3, 71);
            this.feederAliases.Multiline = true;
            this.feederAliases.Name = "feederAliases";
            this.feederAliases.Size = new System.Drawing.Size(107, 101);
            this.feederAliases.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Supplier";
            // 
            // feederSupplier
            // 
            this.feederSupplier.Location = new System.Drawing.Point(186, 32);
            this.feederSupplier.Name = "feederSupplier";
            this.feederSupplier.Size = new System.Drawing.Size(71, 20);
            this.feederSupplier.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Order number";
            // 
            // feederOrderNumber
            // 
            this.feederOrderNumber.Location = new System.Drawing.Point(263, 32);
            this.feederOrderNumber.Name = "feederOrderNumber";
            this.feederOrderNumber.Size = new System.Drawing.Size(71, 20);
            this.feederOrderNumber.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Component name";
            // 
            // feederComponentName
            // 
            this.feederComponentName.Location = new System.Drawing.Point(6, 32);
            this.feederComponentName.Name = "feederComponentName";
            this.feederComponentName.Size = new System.Drawing.Size(104, 20);
            this.feederComponentName.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.feederHead);
            this.groupBox4.Controls.Add(this.feederSpeed);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.feederHeight);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(7, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 62);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Head";
            // 
            // feederHead
            // 
            this.feederHead.Location = new System.Drawing.Point(112, 32);
            this.feederHead.Name = "feederHead";
            this.feederHead.Size = new System.Drawing.Size(47, 20);
            this.feederHead.TabIndex = 5;
            // 
            // feederSpeed
            // 
            this.feederSpeed.Location = new System.Drawing.Point(59, 32);
            this.feederSpeed.Name = "feederSpeed";
            this.feederSpeed.Size = new System.Drawing.Size(47, 20);
            this.feederSpeed.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Speed";
            // 
            // feederHeight
            // 
            this.feederHeight.Location = new System.Drawing.Point(6, 32);
            this.feederHeight.Name = "feederHeight";
            this.feederHeight.Size = new System.Drawing.Size(47, 20);
            this.feederHeight.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Height";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.feederFeedSpacing);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.feederTapeAngle);
            this.groupBox3.Controls.Add(this.feederUseVision);
            this.groupBox3.Controls.Add(this.feederCheckVacuum);
            this.groupBox3.Controls.Add(this.feederPlaceComponent);
            this.groupBox3.Location = new System.Drawing.Point(180, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 198);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attributes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12mm",
            "16mm",
            "24mm",
            "8mm"});
            this.comboBox1.Location = new System.Drawing.Point(67, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tape Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Feed Spacing";
            // 
            // feederFeedSpacing
            // 
            this.feederFeedSpacing.Location = new System.Drawing.Point(6, 141);
            this.feederFeedSpacing.Name = "feederFeedSpacing";
            this.feederFeedSpacing.Size = new System.Drawing.Size(47, 20);
            this.feederFeedSpacing.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Relative Tape Angle";
            // 
            // feederTapeAngle
            // 
            this.feederTapeAngle.Location = new System.Drawing.Point(6, 102);
            this.feederTapeAngle.Name = "feederTapeAngle";
            this.feederTapeAngle.Size = new System.Drawing.Size(47, 20);
            this.feederTapeAngle.TabIndex = 7;
            // 
            // feederUseVision
            // 
            this.feederUseVision.AutoSize = true;
            this.feederUseVision.Location = new System.Drawing.Point(9, 66);
            this.feederUseVision.Name = "feederUseVision";
            this.feederUseVision.Size = new System.Drawing.Size(76, 17);
            this.feederUseVision.TabIndex = 2;
            this.feederUseVision.Text = "Use Vision";
            this.feederUseVision.UseVisualStyleBackColor = true;
            // 
            // feederCheckVacuum
            // 
            this.feederCheckVacuum.AutoSize = true;
            this.feederCheckVacuum.Location = new System.Drawing.Point(9, 43);
            this.feederCheckVacuum.Name = "feederCheckVacuum";
            this.feederCheckVacuum.Size = new System.Drawing.Size(99, 17);
            this.feederCheckVacuum.TabIndex = 1;
            this.feederCheckVacuum.Text = "Check Vacuum";
            this.feederCheckVacuum.UseVisualStyleBackColor = true;
            // 
            // feederPlaceComponent
            // 
            this.feederPlaceComponent.AutoSize = true;
            this.feederPlaceComponent.Location = new System.Drawing.Point(9, 20);
            this.feederPlaceComponent.Name = "feederPlaceComponent";
            this.feederPlaceComponent.Size = new System.Drawing.Size(109, 17);
            this.feederPlaceComponent.TabIndex = 0;
            this.feederPlaceComponent.Text = "Place component";
            this.feederPlaceComponent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.feederCorrectionY);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.feederCorrectionX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 62);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Centroid Correction";
            // 
            // feederCorrectionY
            // 
            this.feederCorrectionY.Location = new System.Drawing.Point(59, 32);
            this.feederCorrectionY.Name = "feederCorrectionY";
            this.feederCorrectionY.Size = new System.Drawing.Size(47, 20);
            this.feederCorrectionY.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // feederCorrectionX
            // 
            this.feederCorrectionX.Location = new System.Drawing.Point(6, 32);
            this.feederCorrectionX.Name = "feederCorrectionX";
            this.feederCorrectionX.Size = new System.Drawing.Size(47, 20);
            this.feederCorrectionX.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feederOffsetY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.feederOffsetX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offset";
            // 
            // feederOffsetY
            // 
            this.feederOffsetY.Location = new System.Drawing.Point(59, 32);
            this.feederOffsetY.Name = "feederOffsetY";
            this.feederOffsetY.Size = new System.Drawing.Size(47, 20);
            this.feederOffsetY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // feederOffsetX
            // 
            this.feederOffsetX.Location = new System.Drawing.Point(6, 32);
            this.feederOffsetX.Name = "feederOffsetX";
            this.feederOffsetX.Size = new System.Drawing.Size(47, 20);
            this.feederOffsetX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // feederIDLabel
            // 
            this.feederIDLabel.AutoSize = true;
            this.feederIDLabel.Location = new System.Drawing.Point(6, 16);
            this.feederIDLabel.Name = "feederIDLabel";
            this.feederIDLabel.Size = new System.Drawing.Size(71, 13);
            this.feederIDLabel.TabIndex = 0;
            this.feederIDLabel.Text = "feeder ID: XX";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(106, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Reel Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 801);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.feederInfoGroup);
            this.tabPage1.Controls.Add(this.machineStack);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.reelStatusLabel);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 775);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stack Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(288, 555);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(361, 185);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nozzle Setup";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(161, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable head 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "502 (0402)",
            "503 (0603)",
            "504 (0805,1206,SOT23)",
            "505 (SOP8, SOP14)",
            "506 (QFN, TQFP)"});
            this.comboBox3.Location = new System.Drawing.Point(161, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Head 2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "502 (0402)",
            "503 (0603)",
            "504 (0805,1206,SOT23)",
            "505 (SOP8, SOP14)",
            "506 (QFN, TQFP)"});
            this.comboBox2.Location = new System.Drawing.Point(11, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Head 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uniquePartsDataView);
            this.tabPage2.Controls.Add(this.uniquePartsLabel);
            this.tabPage2.Controls.Add(this.totalPartsCountLabel);
            this.tabPage2.Controls.Add(this.componentStatusLabel);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 775);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Components";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uniquePartsDataView
            // 
            this.uniquePartsDataView.AllowUserToAddRows = false;
            this.uniquePartsDataView.AllowUserToDeleteRows = false;
            this.uniquePartsDataView.AllowUserToResizeRows = false;
            this.uniquePartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uniquePartsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partsUsed,
            this.value,
            this.package});
            this.uniquePartsDataView.Location = new System.Drawing.Point(9, 35);
            this.uniquePartsDataView.Name = "uniquePartsDataView";
            this.uniquePartsDataView.Size = new System.Drawing.Size(651, 734);
            this.uniquePartsDataView.TabIndex = 9;
            // 
            // partsUsed
            // 
            this.partsUsed.HeaderText = "parts used";
            this.partsUsed.Name = "partsUsed";
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            // 
            // package
            // 
            this.package.HeaderText = "Package";
            this.package.Name = "package";
            this.package.Width = 300;
            // 
            // uniquePartsLabel
            // 
            this.uniquePartsLabel.AutoSize = true;
            this.uniquePartsLabel.Location = new System.Drawing.Point(497, 11);
            this.uniquePartsLabel.Name = "uniquePartsLabel";
            this.uniquePartsLabel.Size = new System.Drawing.Size(106, 13);
            this.uniquePartsLabel.TabIndex = 8;
            this.uniquePartsLabel.Text = "Total Unique parts: 0";
            // 
            // totalPartsCountLabel
            // 
            this.totalPartsCountLabel.AutoSize = true;
            this.totalPartsCountLabel.Location = new System.Drawing.Point(363, 11);
            this.totalPartsCountLabel.Name = "totalPartsCountLabel";
            this.totalPartsCountLabel.Size = new System.Drawing.Size(104, 13);
            this.totalPartsCountLabel.TabIndex = 7;
            this.totalPartsCountLabel.Text = "Total parts loaded: 0";
            // 
            // componentStatusLabel
            // 
            this.componentStatusLabel.AutoSize = true;
            this.componentStatusLabel.Location = new System.Drawing.Point(140, 11);
            this.componentStatusLabel.Name = "componentStatusLabel";
            this.componentStatusLabel.Size = new System.Drawing.Size(141, 13);
            this.componentStatusLabel.TabIndex = 6;
            this.componentStatusLabel.Text = "Component data not loaded!";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Load Component Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.generateDPVFileButton);
            this.tabPage3.Controls.Add(this.MatchingParts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(666, 775);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matching parts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // generateDPVFileButton
            // 
            this.generateDPVFileButton.Location = new System.Drawing.Point(554, 4);
            this.generateDPVFileButton.Name = "generateDPVFileButton";
            this.generateDPVFileButton.Size = new System.Drawing.Size(109, 23);
            this.generateDPVFileButton.TabIndex = 11;
            this.generateDPVFileButton.Text = "Generate DPV file";
            this.generateDPVFileButton.UseVisualStyleBackColor = true;
            this.generateDPVFileButton.Click += new System.EventHandler(this.generateDPVFileButton_Click);
            // 
            // MatchingParts
            // 
            this.MatchingParts.AllowUserToAddRows = false;
            this.MatchingParts.AllowUserToDeleteRows = false;
            this.MatchingParts.AllowUserToResizeRows = false;
            this.MatchingParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchingParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.MatchingParts.Location = new System.Drawing.Point(3, 33);
            this.MatchingParts.Name = "MatchingParts";
            this.MatchingParts.Size = new System.Drawing.Size(660, 704);
            this.MatchingParts.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Package";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // openComponentDataDialog
            // 
            this.openComponentDataDialog.Filter = "KiCad .pos files|*.pos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 819);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "StackTool";
            ((System.ComponentModel.ISupportInitialize)(this.machineStack)).EndInit();
            this.feederInfoGroup.ResumeLayout(false);
            this.feederInfoGroup.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniquePartsDataView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatchingParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openReelDataDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reelStatusLabel;
        private System.Windows.Forms.DataGridView machineStack;
        private System.Windows.Forms.GroupBox feederInfoGroup;
        private System.Windows.Forms.Label feederIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn feederID;
        private System.Windows.Forms.DataGridViewTextBoxColumn component;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox feederOffsetX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox feederAliases;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox feederSupplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox feederOrderNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox feederComponentName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox feederHead;
        private System.Windows.Forms.TextBox feederSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox feederHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox feederFeedSpacing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox feederTapeAngle;
        private System.Windows.Forms.CheckBox feederUseVision;
        private System.Windows.Forms.CheckBox feederCheckVacuum;
        private System.Windows.Forms.CheckBox feederPlaceComponent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox feederCorrectionY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox feederCorrectionX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox feederOffsetY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox feederNotes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label componentStatusLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openComponentDataDialog;
        private System.Windows.Forms.Label totalPartsCountLabel;
        private System.Windows.Forms.Label uniquePartsLabel;
        private System.Windows.Forms.DataGridView uniquePartsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView MatchingParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button generateDPVFileButton;
    }
}

