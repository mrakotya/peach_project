namespace peach_project_
{
    partial class GUIIface
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIIface));
            this.Mode_Lable = new System.Windows.Forms.Label();
            this.Mode_ComboBox = new System.Windows.Forms.ComboBox();
            this.Pit_File_Mode_Panel = new System.Windows.Forms.Panel();
            this.GAChoicepanel = new System.Windows.Forms.Panel();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.PDFbutton = new System.Windows.Forms.Button();
            this.ChartcomboBox = new System.Windows.Forms.ComboBox();
            this.StatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.HomeButton2 = new System.Windows.Forms.Button();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MutationRateTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ScalingcheckBox = new System.Windows.Forms.CheckBox();
            this.MaxAgetextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GenitorRatetextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SurvivalStrategycomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ElitRatetextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ParentsChoicecomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GAApplybutton = new System.Windows.Forms.Button();
            this.BadGenesChildrentextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FitnessStrategyComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GAReturnbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FitnessChoicebutton = new System.Windows.Forms.Button();
            this.PeachTestRangeTestBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BrowseButton3 = new System.Windows.Forms.Button();
            this.BroeswButton2 = new System.Windows.Forms.Button();
            this.BrowseButton1 = new System.Windows.Forms.Button();
            this.PopNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PitFilePathTextBox = new System.Windows.Forms.TextBox();
            this.PathSavePopTextBox = new System.Windows.Forms.TextBox();
            this.PathSaveLogsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Head_Lable_1 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.StatButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PeachFuzzerPlatformTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Pit_File_Mode_Panel.SuspendLayout();
            this.GAChoicepanel.SuspendLayout();
            this.StatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mode_Lable
            // 
            this.Mode_Lable.AutoSize = true;
            this.Mode_Lable.BackColor = System.Drawing.Color.Transparent;
            this.Mode_Lable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode_Lable.ForeColor = System.Drawing.Color.Maroon;
            this.Mode_Lable.Location = new System.Drawing.Point(497, 141);
            this.Mode_Lable.Name = "Mode_Lable";
            this.Mode_Lable.Size = new System.Drawing.Size(126, 26);
            this.Mode_Lable.TabIndex = 0;
            this.Mode_Lable.Text = "Choose Mode";
            this.Mode_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mode_ComboBox
            // 
            this.Mode_ComboBox.AllowDrop = true;
            this.Mode_ComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Mode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mode_ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.Mode_ComboBox.FormattingEnabled = true;
            this.Mode_ComboBox.Items.AddRange(new object[] {
            "None",
            "Pit File Citizens",
            "Modified Input Citizens"});
            this.Mode_ComboBox.Location = new System.Drawing.Point(458, 194);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(207, 31);
            this.Mode_ComboBox.TabIndex = 1;
            this.Mode_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pit_File_Mode_Panel
            // 
            this.Pit_File_Mode_Panel.AutoSize = true;
            this.Pit_File_Mode_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Pit_File_Mode_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pit_File_Mode_Panel.Controls.Add(this.GAChoicepanel);
            this.Pit_File_Mode_Panel.Controls.Add(this.label6);
            this.Pit_File_Mode_Panel.Controls.Add(this.FitnessChoicebutton);
            this.Pit_File_Mode_Panel.Controls.Add(this.PeachTestRangeTestBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.label5);
            this.Pit_File_Mode_Panel.Controls.Add(this.BrowseButton3);
            this.Pit_File_Mode_Panel.Controls.Add(this.BroeswButton2);
            this.Pit_File_Mode_Panel.Controls.Add(this.BrowseButton1);
            this.Pit_File_Mode_Panel.Controls.Add(this.PopNumberComboBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.label4);
            this.Pit_File_Mode_Panel.Controls.Add(this.PitFilePathTextBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.PathSavePopTextBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.PathSaveLogsTextBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.label3);
            this.Pit_File_Mode_Panel.Controls.Add(this.label2);
            this.Pit_File_Mode_Panel.Controls.Add(this.label1);
            this.Pit_File_Mode_Panel.Controls.Add(this.Start_Button);
            this.Pit_File_Mode_Panel.Controls.Add(this.Head_Lable_1);
            this.Pit_File_Mode_Panel.Controls.Add(this.HomeButton);
            this.Pit_File_Mode_Panel.Controls.Add(this.StatButton);
            this.Pit_File_Mode_Panel.Controls.Add(this.label16);
            this.Pit_File_Mode_Panel.Controls.Add(this.label18);
            this.Pit_File_Mode_Panel.Controls.Add(this.PeachFuzzerPlatformTextBox);
            this.Pit_File_Mode_Panel.Controls.Add(this.BrowseButton4);
            this.Pit_File_Mode_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pit_File_Mode_Panel.Location = new System.Drawing.Point(0, 0);
            this.Pit_File_Mode_Panel.Name = "Pit_File_Mode_Panel";
            this.Pit_File_Mode_Panel.Size = new System.Drawing.Size(1106, 462);
            this.Pit_File_Mode_Panel.TabIndex = 3;
            this.Pit_File_Mode_Panel.Visible = false;
            // 
            // GAChoicepanel
            // 
            this.GAChoicepanel.Controls.Add(this.StatPanel);
            this.GAChoicepanel.Controls.Add(this.IterationsTextBox);
            this.GAChoicepanel.Controls.Add(this.label15);
            this.GAChoicepanel.Controls.Add(this.MutationRateTextBox);
            this.GAChoicepanel.Controls.Add(this.label14);
            this.GAChoicepanel.Controls.Add(this.ScalingcheckBox);
            this.GAChoicepanel.Controls.Add(this.MaxAgetextBox);
            this.GAChoicepanel.Controls.Add(this.label13);
            this.GAChoicepanel.Controls.Add(this.GenitorRatetextBox);
            this.GAChoicepanel.Controls.Add(this.label12);
            this.GAChoicepanel.Controls.Add(this.SurvivalStrategycomboBox);
            this.GAChoicepanel.Controls.Add(this.label11);
            this.GAChoicepanel.Controls.Add(this.ElitRatetextBox);
            this.GAChoicepanel.Controls.Add(this.label10);
            this.GAChoicepanel.Controls.Add(this.ParentsChoicecomboBox);
            this.GAChoicepanel.Controls.Add(this.label9);
            this.GAChoicepanel.Controls.Add(this.GAApplybutton);
            this.GAChoicepanel.Controls.Add(this.BadGenesChildrentextBox);
            this.GAChoicepanel.Controls.Add(this.label8);
            this.GAChoicepanel.Controls.Add(this.FitnessStrategyComboBox);
            this.GAChoicepanel.Controls.Add(this.label7);
            this.GAChoicepanel.Controls.Add(this.GAReturnbutton);
            this.GAChoicepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GAChoicepanel.Location = new System.Drawing.Point(0, 0);
            this.GAChoicepanel.Name = "GAChoicepanel";
            this.GAChoicepanel.Size = new System.Drawing.Size(1106, 462);
            this.GAChoicepanel.TabIndex = 18;
            this.GAChoicepanel.Visible = false;
            // 
            // StatPanel
            // 
            this.StatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatPanel.Controls.Add(this.PDFbutton);
            this.StatPanel.Controls.Add(this.ChartcomboBox);
            this.StatPanel.Controls.Add(this.StatisticsChart);
            this.StatPanel.Controls.Add(this.OutputTextBox);
            this.StatPanel.Controls.Add(this.HomeButton2);
            this.StatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatPanel.ForeColor = System.Drawing.Color.Maroon;
            this.StatPanel.Location = new System.Drawing.Point(0, 0);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(1106, 462);
            this.StatPanel.TabIndex = 21;
            this.StatPanel.Visible = false;
            // 
            // PDFbutton
            // 
            this.PDFbutton.BackColor = System.Drawing.Color.Transparent;
            this.PDFbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFbutton.ForeColor = System.Drawing.Color.Maroon;
            this.PDFbutton.Location = new System.Drawing.Point(682, 408);
            this.PDFbutton.Name = "PDFbutton";
            this.PDFbutton.Size = new System.Drawing.Size(98, 42);
            this.PDFbutton.TabIndex = 5;
            this.PDFbutton.Text = "Save";
            this.PDFbutton.UseVisualStyleBackColor = false;
            this.PDFbutton.Click += new System.EventHandler(this.PDFbutton_Click);
            // 
            // ChartcomboBox
            // 
            this.ChartcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartcomboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartcomboBox.ForeColor = System.Drawing.Color.Black;
            this.ChartcomboBox.FormattingEnabled = true;
            this.ChartcomboBox.Items.AddRange(new object[] {
            "Invalid Pits(%) Per Iter",
            "Convergency Per Iter",
            "Average Fitness Per Iter",
            "% of Fault Pits",
            "All"});
            this.ChartcomboBox.Location = new System.Drawing.Point(922, 17);
            this.ChartcomboBox.Name = "ChartcomboBox";
            this.ChartcomboBox.Size = new System.Drawing.Size(172, 31);
            this.ChartcomboBox.TabIndex = 4;
            this.ChartcomboBox.SelectedIndexChanged += new System.EventHandler(this.ChartcomboBox_SelectedIndexChanged);
            // 
            // StatisticsChart
            // 
            this.StatisticsChart.BackColor = System.Drawing.Color.LightGray;
            this.StatisticsChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.Title = "Iterations";
            chartArea1.AxisY.Title = "Value";
            chartArea1.Name = "ChartArea1";
            this.StatisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StatisticsChart.Legends.Add(legend1);
            this.StatisticsChart.Location = new System.Drawing.Point(218, 9);
            this.StatisticsChart.Name = "StatisticsChart";
            this.StatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.StatisticsChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.OliveDrab,
        System.Drawing.Color.Red,
        System.Drawing.Color.Empty};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StatisticsChart.Series.Add(series1);
            this.StatisticsChart.Size = new System.Drawing.Size(698, 374);
            this.StatisticsChart.TabIndex = 3;
            this.StatisticsChart.Text = "chart1";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.LightGray;
            this.OutputTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.OutputTextBox.Location = new System.Drawing.Point(38, 30);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(174, 399);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            // 
            // HomeButton2
            // 
            this.HomeButton2.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton2.ForeColor = System.Drawing.Color.Maroon;
            this.HomeButton2.Location = new System.Drawing.Point(818, 408);
            this.HomeButton2.Name = "HomeButton2";
            this.HomeButton2.Size = new System.Drawing.Size(98, 42);
            this.HomeButton2.TabIndex = 0;
            this.HomeButton2.Text = "Home";
            this.HomeButton2.UseVisualStyleBackColor = false;
            this.HomeButton2.Click += new System.EventHandler(this.HomeButton2_Click);
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationsTextBox.Location = new System.Drawing.Point(260, 310);
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(175, 30);
            this.IterationsTextBox.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(15, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Iterations";
            // 
            // MutationRateTextBox
            // 
            this.MutationRateTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationRateTextBox.Location = new System.Drawing.Point(260, 238);
            this.MutationRateTextBox.Name = "MutationRateTextBox";
            this.MutationRateTextBox.Size = new System.Drawing.Size(173, 30);
            this.MutationRateTextBox.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(15, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "MutationRate";
            // 
            // ScalingcheckBox
            // 
            this.ScalingcheckBox.AutoSize = true;
            this.ScalingcheckBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScalingcheckBox.ForeColor = System.Drawing.Color.Maroon;
            this.ScalingcheckBox.Location = new System.Drawing.Point(458, 174);
            this.ScalingcheckBox.Name = "ScalingcheckBox";
            this.ScalingcheckBox.Size = new System.Drawing.Size(101, 22);
            this.ScalingcheckBox.TabIndex = 16;
            this.ScalingcheckBox.Text = "WithScaling";
            this.ScalingcheckBox.UseVisualStyleBackColor = true;
            this.ScalingcheckBox.CheckedChanged += new System.EventHandler(this.ScalingcheckBox_CheckedChanged);
            // 
            // MaxAgetextBox
            // 
            this.MaxAgetextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxAgetextBox.Location = new System.Drawing.Point(896, 248);
            this.MaxAgetextBox.Name = "MaxAgetextBox";
            this.MaxAgetextBox.Size = new System.Drawing.Size(168, 30);
            this.MaxAgetextBox.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(681, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "MaxAge";
            // 
            // GenitorRatetextBox
            // 
            this.GenitorRatetextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenitorRatetextBox.Location = new System.Drawing.Point(896, 173);
            this.GenitorRatetextBox.Name = "GenitorRatetextBox";
            this.GenitorRatetextBox.Size = new System.Drawing.Size(168, 30);
            this.GenitorRatetextBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(681, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "GenitorRate";
            // 
            // SurvivalStrategycomboBox
            // 
            this.SurvivalStrategycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurvivalStrategycomboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurvivalStrategycomboBox.FormattingEnabled = true;
            this.SurvivalStrategycomboBox.Items.AddRange(new object[] {
            "Elitism",
            "Aging",
            "Genitor"});
            this.SurvivalStrategycomboBox.Location = new System.Drawing.Point(896, 36);
            this.SurvivalStrategycomboBox.Name = "SurvivalStrategycomboBox";
            this.SurvivalStrategycomboBox.Size = new System.Drawing.Size(168, 31);
            this.SurvivalStrategycomboBox.TabIndex = 11;
            this.SurvivalStrategycomboBox.SelectedIndexChanged += new System.EventHandler(this.SurvivalStrategycomboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(681, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Survival Strategy";
            // 
            // ElitRatetextBox
            // 
            this.ElitRatetextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElitRatetextBox.Location = new System.Drawing.Point(896, 98);
            this.ElitRatetextBox.Name = "ElitRatetextBox";
            this.ElitRatetextBox.Size = new System.Drawing.Size(168, 30);
            this.ElitRatetextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(681, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "ElitRate";
            // 
            // ParentsChoicecomboBox
            // 
            this.ParentsChoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentsChoicecomboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsChoicecomboBox.FormattingEnabled = true;
            this.ParentsChoicecomboBox.Items.AddRange(new object[] {
            "Naive",
            "FPS",
            "Tournament"});
            this.ParentsChoicecomboBox.Location = new System.Drawing.Point(258, 164);
            this.ParentsChoicecomboBox.Name = "ParentsChoicecomboBox";
            this.ParentsChoicecomboBox.Size = new System.Drawing.Size(175, 31);
            this.ParentsChoicecomboBox.TabIndex = 7;
            this.ParentsChoicecomboBox.SelectedIndexChanged += new System.EventHandler(this.ParentsChoicecomboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(12, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Parents Choice Strategy";
            // 
            // GAApplybutton
            // 
            this.GAApplybutton.BackColor = System.Drawing.Color.Transparent;
            this.GAApplybutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAApplybutton.ForeColor = System.Drawing.Color.Maroon;
            this.GAApplybutton.Location = new System.Drawing.Point(818, 340);
            this.GAApplybutton.Name = "GAApplybutton";
            this.GAApplybutton.Size = new System.Drawing.Size(98, 42);
            this.GAApplybutton.TabIndex = 5;
            this.GAApplybutton.Text = "Apply";
            this.GAApplybutton.UseVisualStyleBackColor = false;
            this.GAApplybutton.Click += new System.EventHandler(this.GAApplybutton_Click);
            // 
            // BadGenesChildrentextBox
            // 
            this.BadGenesChildrentextBox.Enabled = false;
            this.BadGenesChildrentextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BadGenesChildrentextBox.Location = new System.Drawing.Point(258, 98);
            this.BadGenesChildrentextBox.Name = "BadGenesChildrentextBox";
            this.BadGenesChildrentextBox.Size = new System.Drawing.Size(175, 30);
            this.BadGenesChildrentextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(8, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "% Of Children with Bad Genes";
            // 
            // FitnessStrategyComboBox
            // 
            this.FitnessStrategyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FitnessStrategyComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitnessStrategyComboBox.FormattingEnabled = true;
            this.FitnessStrategyComboBox.Items.AddRange(new object[] {
            "Good Files Only",
            "Bad Files Partially",
            "All Bad Files"});
            this.FitnessStrategyComboBox.Location = new System.Drawing.Point(258, 36);
            this.FitnessStrategyComboBox.Name = "FitnessStrategyComboBox";
            this.FitnessStrategyComboBox.Size = new System.Drawing.Size(175, 31);
            this.FitnessStrategyComboBox.TabIndex = 2;
            this.FitnessStrategyComboBox.SelectedIndexChanged += new System.EventHandler(this.FitnessStrategyComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(11, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Choose Fitness strategy";
            // 
            // GAReturnbutton
            // 
            this.GAReturnbutton.BackColor = System.Drawing.Color.Transparent;
            this.GAReturnbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAReturnbutton.ForeColor = System.Drawing.Color.Maroon;
            this.GAReturnbutton.Location = new System.Drawing.Point(818, 408);
            this.GAReturnbutton.Name = "GAReturnbutton";
            this.GAReturnbutton.Size = new System.Drawing.Size(98, 42);
            this.GAReturnbutton.TabIndex = 0;
            this.GAReturnbutton.Text = "Return";
            this.GAReturnbutton.UseVisualStyleBackColor = false;
            this.GAReturnbutton.Click += new System.EventHandler(this.GAReturnbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(481, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "GA Strategy";
            // 
            // FitnessChoicebutton
            // 
            this.FitnessChoicebutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitnessChoicebutton.ForeColor = System.Drawing.Color.Maroon;
            this.FitnessChoicebutton.Location = new System.Drawing.Point(485, 249);
            this.FitnessChoicebutton.Name = "FitnessChoicebutton";
            this.FitnessChoicebutton.Size = new System.Drawing.Size(191, 31);
            this.FitnessChoicebutton.TabIndex = 16;
            this.FitnessChoicebutton.Text = "Press To Choose";
            this.FitnessChoicebutton.UseVisualStyleBackColor = true;
            this.FitnessChoicebutton.Click += new System.EventHandler(this.FitnessChoicebutton_Click);
            // 
            // PeachTestRangeTestBox
            // 
            this.PeachTestRangeTestBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeachTestRangeTestBox.Location = new System.Drawing.Point(485, 132);
            this.PeachTestRangeTestBox.Name = "PeachTestRangeTestBox";
            this.PeachTestRangeTestBox.Size = new System.Drawing.Size(196, 30);
            this.PeachTestRangeTestBox.TabIndex = 15;
            this.PeachTestRangeTestBox.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(481, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Peach Test Range";
            // 
            // BrowseButton3
            // 
            this.BrowseButton3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton3.ForeColor = System.Drawing.Color.Maroon;
            this.BrowseButton3.Location = new System.Drawing.Point(244, 386);
            this.BrowseButton3.Name = "BrowseButton3";
            this.BrowseButton3.Size = new System.Drawing.Size(98, 42);
            this.BrowseButton3.TabIndex = 13;
            this.BrowseButton3.Text = "Browse...";
            this.BrowseButton3.UseVisualStyleBackColor = true;
            this.BrowseButton3.Click += new System.EventHandler(this.BrowseButton3_Click);
            // 
            // BroeswButton2
            // 
            this.BroeswButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BroeswButton2.ForeColor = System.Drawing.Color.Maroon;
            this.BroeswButton2.Location = new System.Drawing.Point(244, 290);
            this.BroeswButton2.Name = "BroeswButton2";
            this.BroeswButton2.Size = new System.Drawing.Size(98, 42);
            this.BroeswButton2.TabIndex = 12;
            this.BroeswButton2.Text = "Browse...";
            this.BroeswButton2.UseVisualStyleBackColor = true;
            this.BroeswButton2.Click += new System.EventHandler(this.BroeswButton2_Click);
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton1.ForeColor = System.Drawing.Color.Maroon;
            this.BrowseButton1.Location = new System.Drawing.Point(244, 183);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(98, 42);
            this.BrowseButton1.TabIndex = 11;
            this.BrowseButton1.Text = "Browse...";
            this.BrowseButton1.UseVisualStyleBackColor = false;
            this.BrowseButton1.Click += new System.EventHandler(this.BrowseButton1_Click);
            // 
            // PopNumberComboBox
            // 
            this.PopNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PopNumberComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopNumberComboBox.ForeColor = System.Drawing.Color.Black;
            this.PopNumberComboBox.FormattingEnabled = true;
            this.PopNumberComboBox.Items.AddRange(new object[] {
            "5",
            "100",
            "500",
            "1000"});
            this.PopNumberComboBox.Location = new System.Drawing.Point(485, 371);
            this.PopNumberComboBox.Name = "PopNumberComboBox";
            this.PopNumberComboBox.Size = new System.Drawing.Size(175, 31);
            this.PopNumberComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(481, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Population Number";
            // 
            // PitFilePathTextBox
            // 
            this.PitFilePathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PitFilePathTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PitFilePathTextBox.Location = new System.Drawing.Point(32, 198);
            this.PitFilePathTextBox.Name = "PitFilePathTextBox";
            this.PitFilePathTextBox.Size = new System.Drawing.Size(196, 26);
            this.PitFilePathTextBox.TabIndex = 8;
            // 
            // PathSavePopTextBox
            // 
            this.PathSavePopTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathSavePopTextBox.Location = new System.Drawing.Point(32, 306);
            this.PathSavePopTextBox.Name = "PathSavePopTextBox";
            this.PathSavePopTextBox.Size = new System.Drawing.Size(196, 26);
            this.PathSavePopTextBox.TabIndex = 7;
            // 
            // PathSaveLogsTextBox
            // 
            this.PathSaveLogsTextBox.Location = new System.Drawing.Point(32, 408);
            this.PathSaveLogsTextBox.Name = "PathSaveLogsTextBox";
            this.PathSaveLogsTextBox.Size = new System.Drawing.Size(196, 20);
            this.PathSaveLogsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(28, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path To Save Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(28, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path To Save Logs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Pit File Path";
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Start_Button.Location = new System.Drawing.Point(818, 340);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(98, 42);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Head_Lable_1
            // 
            this.Head_Lable_1.AutoSize = true;
            this.Head_Lable_1.BackColor = System.Drawing.Color.Transparent;
            this.Head_Lable_1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head_Lable_1.ForeColor = System.Drawing.Color.Maroon;
            this.Head_Lable_1.Location = new System.Drawing.Point(478, 20);
            this.Head_Lable_1.Name = "Head_Lable_1";
            this.Head_Lable_1.Size = new System.Drawing.Size(180, 38);
            this.Head_Lable_1.TabIndex = 0;
            this.Head_Lable_1.Text = "Pit File Mode";
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.HomeButton.Location = new System.Drawing.Point(818, 408);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(98, 42);
            this.HomeButton.TabIndex = 19;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // StatButton
            // 
            this.StatButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatButton.ForeColor = System.Drawing.Color.Maroon;
            this.StatButton.Location = new System.Drawing.Point(942, 194);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(145, 41);
            this.StatButton.TabIndex = 20;
            this.StatButton.Text = "Show";
            this.StatButton.UseVisualStyleBackColor = true;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(970, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Statistics";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(28, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Peach Fuzzer Platform Path";
            // 
            // PeachFuzzerPlatformTextBox
            // 
            this.PeachFuzzerPlatformTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PeachFuzzerPlatformTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeachFuzzerPlatformTextBox.Location = new System.Drawing.Point(32, 78);
            this.PeachFuzzerPlatformTextBox.Name = "PeachFuzzerPlatformTextBox";
            this.PeachFuzzerPlatformTextBox.Size = new System.Drawing.Size(196, 26);
            this.PeachFuzzerPlatformTextBox.TabIndex = 24;
            // 
            // BrowseButton4
            // 
            this.BrowseButton4.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton4.ForeColor = System.Drawing.Color.Maroon;
            this.BrowseButton4.Location = new System.Drawing.Point(244, 62);
            this.BrowseButton4.Name = "BrowseButton4";
            this.BrowseButton4.Size = new System.Drawing.Size(98, 42);
            this.BrowseButton4.TabIndex = 25;
            this.BrowseButton4.Text = "Browse...";
            this.BrowseButton4.UseVisualStyleBackColor = false;
            this.BrowseButton4.Click += new System.EventHandler(this.BrowseButton4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 144);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GUIIface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pit_File_Mode_Panel);
            this.Controls.Add(this.Mode_ComboBox);
            this.Controls.Add(this.Mode_Lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIIface";
            this.Text = "GA Peach Framework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pit_File_Mode_Panel.ResumeLayout(false);
            this.Pit_File_Mode_Panel.PerformLayout();
            this.GAChoicepanel.ResumeLayout(false);
            this.GAChoicepanel.PerformLayout();
            this.StatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mode_Lable;
        private System.Windows.Forms.ComboBox Mode_ComboBox;
        private System.Windows.Forms.Panel Pit_File_Mode_Panel;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Head_Lable_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PitFilePathTextBox;
        private System.Windows.Forms.TextBox PathSavePopTextBox;
        private System.Windows.Forms.TextBox PathSaveLogsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PopNumberComboBox;
        private System.Windows.Forms.Button BrowseButton3;
        private System.Windows.Forms.Button BroeswButton2;
        private System.Windows.Forms.Button BrowseButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PeachTestRangeTestBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FitnessChoicebutton;
        private System.Windows.Forms.Panel GAChoicepanel;
        private System.Windows.Forms.Button GAReturnbutton;
        private System.Windows.Forms.ComboBox FitnessStrategyComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BadGenesChildrentextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GAApplybutton;
        private System.Windows.Forms.ComboBox ParentsChoicecomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ElitRatetextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SurvivalStrategycomboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GenitorRatetextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MaxAgetextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ScalingcheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MutationRateTextBox;
        private System.Windows.Forms.TextBox IterationsTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Button HomeButton2;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.ComboBox ChartcomboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatisticsChart;
        private System.Windows.Forms.Button PDFbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BrowseButton4;
        private System.Windows.Forms.TextBox PeachFuzzerPlatformTextBox;
    }
}

