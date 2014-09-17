using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.XPath;

namespace peach_project_
{
    public partial class GUIIface : Form
    {
        //fields of the object of GUIIface type
        int FitnessStrategy; //fitness strategy by number
        String FitnessStrategy_name;//fitness strategy by name
        int BadGenesChildren;//number of children haveng invalid Peach Pit files as parents
        int parentsChoiceStrategy;//parents selection strategy by number
        String ParentsChoiceStrategy_name;//parents selection strategy by name
        int elitrate;//elitism rate
        int survivalStrategy;//survival strategy by number
        String survivalStrategy_name;//survival strategy by name
        int genrate;//genitor rate
        int maxAge;//maximum age for aging survival strategy
        bool withScaling = false;//use scaling ?
        double mutationRate;//mutation rate
        int iterations;//number of iterations
        String PitFilePath;//
        String logsPath;//path to save logs
        String PathOfPitPopulation;//path to save population
        String PeachFuzzerPlatformPath;//cmd to run peach fuzzer platform
        int population;//number of population
        String PeachTestRange;//number of tests tu run on each citizen
        String PDFpath;//patht to save output
        String PDFtime;

//===================================================================Basic_functions========================================================================
        
        //constructor
        public GUIIface()
        {
            InitializeComponent();
        }


        //function od selecting mode
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select "Pit File Mode" for a current session
            if (Mode_ComboBox.Text == "Pit File Citizens")
            {
                Pit_File_Mode_Panel.Visible = true;

            }
            else if (Mode_ComboBox.Text == "Modified Input Citizens")
            {
               //this part was to be added optionally
                MessageBox.Show("This part is not implemented in the current version of the program");
            }

        }

        //start session
        private void Start_Button_Click(object sender, EventArgs e)
        {
           
            Mode_ComboBox.SelectedIndex = 0;
            //check parameters
            if (!paramCheck(Pit_File_Mode_Panel))
            {
                MessageBox.Show("Incorrect parameters. Check data you have inserted.");
                SetDefaultValues();
                return;
            }
            if (!paramCheck(GAChoicepanel))
            {
                MessageBox.Show("Incorrect parameters. Check data you have inserted.");
                SetDefaultValues();
                return;
            }


            //disable controls to avoid user actions while running
            DisableControls(Pit_File_Mode_Panel);
            DisableControls(GAChoicepanel);
            //parse all the parameters
            PitFilePath = PitFilePathTextBox.Text.ToString();
            logsPath = PathSaveLogsTextBox.Text.ToString();
            PathOfPitPopulation = PathSavePopTextBox.Text.ToString();
            PeachFuzzerPlatformPath = PeachFuzzerPlatformTextBox.Text.ToString();
            population = Convert.ToInt32(PopNumberComboBox.SelectedItem.ToString());
            PeachTestRange = PeachTestRangeTestBox.Text.ToString();
            FitnessStrategy = FitnessStrategyComboBox.SelectedIndex;
            FitnessStrategy_name = FitnessStrategyComboBox.SelectedItem.ToString();
            if (FitnessStrategy == 1 || FitnessStrategy == 0)
                BadGenesChildren = Convert.ToInt32(BadGenesChildrentextBox.Text.ToString());
            else
                BadGenesChildren = 100;
            parentsChoiceStrategy = ParentsChoicecomboBox.SelectedIndex;
            ParentsChoiceStrategy_name = ParentsChoicecomboBox.SelectedItem.ToString();
            elitrate = Convert.ToInt32(ElitRatetextBox.Text.ToString());
            survivalStrategy = SurvivalStrategycomboBox.SelectedIndex;
            survivalStrategy_name = SurvivalStrategycomboBox.SelectedItem.ToString();
            genrate = Convert.ToInt32(GenitorRatetextBox.Text.ToString());
            maxAge = Convert.ToInt32(MaxAgetextBox.Text.ToString());
            mutationRate = Convert.ToDouble(MutationRateTextBox.Text.ToString());
            iterations = Convert.ToInt32(IterationsTextBox.Text.ToString());

            //prepare all the parameters before starting the run
            Parameters parm = new Parameters();
            parm.setLogsPath(logsPath);
            parm.setPopulation(population);
            parm.setPathOfPitPopulation(PathOfPitPopulation);
            parm.setPeachFuzzerPlatformPath(PeachFuzzerPlatformPath);
            parm.setPeachTestrange(PeachTestRange);
            parm.setBadGeneschildren(BadGenesChildren);
            parm.setParentsChiceStrategy(parentsChoiceStrategy);
            parm.setElitrate(elitrate);
            parm.setSurvivalStrategy(survivalStrategy);
            parm.setGenrate(genrate);
            parm.setMaxAge( maxAge);
            parm.setWithScaling(withScaling);
            parm.setpitFilepath(PitFilePath);
            parm.setMutationRate(mutationRate);
            parm.setIterations(iterations);

            //start program
            PitFileMode.PitFileMode_main(parm);

            //enable controls and return to the home page
            SetDefaultValues();
            StatButton.Enabled = true;
        }


        private void Start_Button_2_Click(object sender, EventArgs e)
        {
            Pit_File_Mode_Panel.Visible = false;
            Mode_ComboBox.SelectedIndex = 0;
        }

        //load the form and set all default values if they exist
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        //choose necessary path by means of dialog box
        private void BrowseButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PitFilePathTextBox.Text = opd.FileName;
            }
        }

        //choose necessary path by means of dialog box
        private void BroeswButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathSaveLogsTextBox.Text = opd.FileName;
            }
        }

        //choose necessary path by means of dialog box
        private void BrowseButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PitFilePathTextBox.Text = fbd.SelectedPath;
            }
        }



        private void FitnessChoicebutton_Click(object sender, EventArgs e)
        {
            GAChoicepanel.Visible = true;

        }

        //function of returning to the Pit File Mode window
        private void GAReturnbutton_Click(object sender, EventArgs e)
        {
            if (applyGAvalues() == 0)
            {
                if (parentsChoiceStrategy == 0 && elitrate == 0)
                    MessageBox.Show("Naive selection requires elitrate > 0");
                else

                    GAChoicepanel.Visible = false;
            }

        }

        //chose fitness stratefy
        private void FitnessStrategyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FitnessStrategyComboBox.SelectedIndex == 1)
            {
                BadGenesChildrentextBox.Enabled = true;
            }
            else
                BadGenesChildrentextBox.Enabled = false;

        }

        //applying chosen parameters
        private void GAApplybutton_Click(object sender, EventArgs e)
        {

            if (applyGAvalues() == 0)
            { 
            if (parentsChoiceStrategy == 0 && elitrate == 0)
                MessageBox.Show("Naive selection requires elitrate > 0");
            }

        }



//================================================================================extra functions============================================================================
       //disable all the controls on the panel
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        //enable all the controls on the panel
        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                foreach (Control c in con.Controls)
                {
                    EnableControls(c);
                }
            }
        }

        //check inserted parameters
        private bool paramCheck(Control con)
        { 
            int val;
            double val1;
            
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Enabled==true && c.Text == String.Empty ) return false;
                    if (c.Name == "PeachTestRangeTestBox" || c.Name == "MaxAgetextBox" || c.Name == "IterationsTextBox")
                    {
                       
                        if (!int.TryParse(c.Text, out val)) return false;
                        if (val < 0) return false;
                    }
                    if (c.Name == "BadFilePercenttextBox" || c.Name == "ElitRatetextBox" || c.Name == "GenitorRatetextBox")
                    {
                        if (!int.TryParse(c.Text, out val)) return false;
                        if (val < 0 || val > 100) return false;
                    }

                    if (c.Name == "MutationRateTextBox")
                    {
                    if (!double.TryParse(c.Text, out val1)) return false;
                    if (val1 < 0 || val1 > 1) return false;
                    }

                    if (c.Name == "PeachFuzzerPlatformTextBox" || c.Name == "PitFilePathTextBox" || c.Name == "PathSavePopTextBox" || c.Name == "PathSaveLogsTextBox")
                    {

                        if (!Directory.Exists(Path.GetDirectoryName(c.Text.ToString())))
                            return false;

                    }
                
                }
            }
            return true;
        
        }

        //set default values as parameters
        private void SetDefaultValues()
        {
            Mode_ComboBox.SelectedIndex = 0;
            PopNumberComboBox.SelectedIndex = 0;       
            PitFilePathTextBox.Text = @"C:\Users\Masha\Downloads\peach_svn\samples\zip_fuzz.xml";
            PathSaveLogsTextBox.Text = @"C:\Users\Masha\Documents\Visual Studio 2010\Projects\peach_project_\peach_project_\logs\";
            PathSavePopTextBox.Text = @"C:\Users\Masha\Downloads\peach_svn\samples\mutated\";
            PeachFuzzerPlatformTextBox.Text = @"C:\Users\Masha\Downloads\peach_svn\peach.bat";
            EnableControls(Pit_File_Mode_Panel);
            EnableControls(GAChoicepanel);
            FitnessStrategyComboBox.Enabled = true;
            BadGenesChildrentextBox.Enabled = false;
            FitnessStrategyComboBox.SelectedIndex = 0;
            BadGenesChildrentextBox.Text = "0";
            ElitRatetextBox.Enabled = true;
            ElitRatetextBox.Text = "10";
            ParentsChoicecomboBox.SelectedIndex = 0;
            SurvivalStrategycomboBox.SelectedIndex = 0;
            GenitorRatetextBox.Text = "10";
            GenitorRatetextBox.Enabled = false;
            MaxAgetextBox.Enabled = false;
            MaxAgetextBox.Text = "0";
            MutationRateTextBox.Text = "0.1";
            StatButton.Enabled = false;
            ChartcomboBox.SelectedIndex = 0;
            StatisticsChart.Visible = false;
            StatisticsChart.Series.Clear();
            PDFbutton.Enabled = false;
            ScalingcheckBox.Enabled = false;
            PeachTestRangeTestBox.Text = "2";
           // IterationsTextBox.Text = String.Empty;
        }

       
        //apply chosen parameters
        private int applyGAvalues()
        {
            if (!paramCheck(GAChoicepanel))
            {
                MessageBox.Show("Incorrect parameters. Check data you have inserted.");
                SetDefaultValues();
                return 1;
            }
            FitnessStrategy = FitnessStrategyComboBox.SelectedIndex;
            FitnessStrategy_name = FitnessStrategyComboBox.SelectedItem.ToString();
            if (FitnessStrategy == 1)
                BadGenesChildren = Convert.ToInt32(BadGenesChildrentextBox.Text.ToString());

            parentsChoiceStrategy = ParentsChoicecomboBox.SelectedIndex;
            ParentsChoiceStrategy_name = ParentsChoicecomboBox.SelectedItem.ToString();

            elitrate = Convert.ToInt32(ElitRatetextBox.Text.ToString());
            genrate = Convert.ToInt32(GenitorRatetextBox.Text.ToString());
            maxAge = Convert.ToInt32(MaxAgetextBox.Text.ToString());
            mutationRate = Convert.ToDouble(MutationRateTextBox.Text.ToString());
            return 0;
        }

//==========================================================Basic_functions_2=============================================================================

        private void SurvivalStrategycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurvivalStrategycomboBox.SelectedIndex == 0 || SurvivalStrategycomboBox.SelectedIndex == 1)//elitism or aging
            {
                ElitRatetextBox.Enabled = true;
            }
            else
            {
                ElitRatetextBox.Enabled = false;
                ElitRatetextBox.Text = "10";
            }
            if (SurvivalStrategycomboBox.SelectedIndex == 2)
            {
                GenitorRatetextBox.Enabled = true;
            }
            else
            {
                GenitorRatetextBox.Enabled = false;
                GenitorRatetextBox.Text = "10";
            }
            if (SurvivalStrategycomboBox.SelectedIndex == 1)
            {
                MaxAgetextBox.Enabled = true;
            }
            else {

                MaxAgetextBox.Enabled = false;
            }


        }

        private void ParentsChoicecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              ScalingcheckBox.Enabled = false;
            if (ParentsChoicecomboBox.SelectedIndex != 0)
            {
                FitnessStrategyComboBox.SelectedIndex = 0;
                FitnessStrategyComboBox.Enabled = false;
                BadGenesChildrentextBox.Text = "0";
                BadGenesChildrentextBox.Enabled = false;
                if(ParentsChoicecomboBox.SelectedIndex == 1)
                    ScalingcheckBox.Enabled = true;
            }
            else
            {
                FitnessStrategyComboBox.Enabled = true;
                BadGenesChildrentextBox.Enabled = false;
            }
        }

        //apply scaling to the FPS strategy
        private void ScalingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ScalingcheckBox.Checked == true)
            {
                withScaling = true;
            }
            else withScaling = false;
        }

        //return to the starting window
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            Pit_File_Mode_Panel.Visible = false;
        }

        //show statistic window
        private void StatButton_Click(object sender, EventArgs e)
        {
            GAChoicepanel.Visible = true;
            StatPanel.Visible = true;
            OutputTextBox.Clear();
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 8, FontStyle.Bold);
            OutputTextBox.AppendText("LAST RUN PARAMETERS\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Original PitFile Path:\r\n");
            OutputTextBox.AppendText(this.PitFilePath.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Population Saved At:\r\n");
            OutputTextBox.AppendText(this.PathOfPitPopulation.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Fault Logs Saved At:\r\n");
            OutputTextBox.AppendText(this.PathOfPitPopulation.ToString() +@"faults" + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Peach Test Range:\r\n");
            OutputTextBox.AppendText(this.PeachTestRange.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Population Size:\r\n");
            OutputTextBox.AppendText(this.population.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Number Of Iterations:\r\n");
            OutputTextBox.AppendText(this.iterations.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Mutation Rate:\r\n");
            OutputTextBox.AppendText(this.mutationRate.ToString() + "\r\n\r\n");
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Parents Selection Strategy:\r\n");
            OutputTextBox.AppendText(this.ParentsChoiceStrategy_name.ToString() + "\r\n\r\n");
            if(parentsChoiceStrategy==0)
            {
                OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                    OutputTextBox.AppendText("Fitness Strategy:\r\n");
                    OutputTextBox.AppendText(this.FitnessStrategy_name.ToString() + "\r\n\r\n");
                    OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                    OutputTextBox.AppendText("Percent of children with Bad Genes:\r\n");
                    OutputTextBox.AppendText(this.BadGenesChildren.ToString() + "\r\n\r\n");     
            }
            OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
            OutputTextBox.AppendText("Survival Strategy:\r\n");
            OutputTextBox.AppendText(this.survivalStrategy_name.ToString() + "\r\n\r\n");
            if (survivalStrategy != 2)
            {
                OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                OutputTextBox.AppendText("Elitism Rate:\r\n");
                OutputTextBox.AppendText(this.elitrate.ToString() + "\r\n\r\n");
            }
            if (survivalStrategy == 1)
            {
                OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                OutputTextBox.AppendText("Maximum Age:\r\n");
                OutputTextBox.AppendText(this.maxAge.ToString() + "\r\n\r\n");
                OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                OutputTextBox.AppendText("Scaling Used:\r\n");
                OutputTextBox.AppendText(this.withScaling.ToString() + "\r\n\r\n");
            }

            if (survivalStrategy == 2)
            {
                OutputTextBox.SelectionFont = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
                OutputTextBox.AppendText("Genitor Rate:\r\n");
                OutputTextBox.AppendText(this.genrate.ToString() + "\r\n\r\n");
            }

            PDFbutton.Enabled = false;
            XDocument xmlDoc = XDocument.Load(@PathOfPitPopulation + @"statistics/stat.xml");
            var iterations = xmlDoc.XPathSelectElements("RUN/ITERATION");

            foreach (var itr in iterations)
            {
                if (StatisticsChart.Series.IndexOf("Invalid Pits") == -1)
                {
                    StatisticsChart.Series.Add("Invalid Pits");
                }
                StatisticsChart.Series["Invalid Pits"].Enabled = false;
                string j = itr.Descendants("INVALID_PITS").Attributes("value").First().Value.ToString();
                StatisticsChart.Series["Invalid Pits"].Points.AddXY(itr.Attribute("value").Value.ToString(), itr.Descendants("INVALID_PITS").Attributes("value").First().Value.ToString());

                if (StatisticsChart.Series.IndexOf("Convergence") == -1)
                {
                    StatisticsChart.Series.Add("Convergence");
                }
                StatisticsChart.Series["Convergence"].Points.AddXY(itr.Attribute("value").Value.ToString(), itr.Descendants("CONVERGENCE").Attributes("value").First().Value.ToString());
                StatisticsChart.Series["Convergence"].Enabled = false;

                if (StatisticsChart.Series.IndexOf("Average Fitness") == -1)
                {
                    StatisticsChart.Series.Add("Average Fitness");
                }
                StatisticsChart.Series["Average Fitness"].Points.AddXY(itr.Attribute("value").Value.ToString(), itr.Descendants("AVERAGE_FTNS").Attributes("value").First().Value.ToString());
                StatisticsChart.Series["Average Fitness"].Enabled = false;

                if (StatisticsChart.Series.IndexOf("Fault Pits") == -1)
                {
                    StatisticsChart.Series.Add("Fault Pits");
                }
                StatisticsChart.Series["Fault Pits"].Points.AddXY(itr.Attribute("value").Value.ToString(), itr.Descendants("FAULT_PITS").Attributes("value").First().Value.ToString());
                StatisticsChart.Series["Fault Pits"].Enabled = false;


            }
        }

        //return to the starting window
        private void HomeButton2_Click(object sender, EventArgs e)
        {

            SetDefaultValues();
            GAChoicepanel.Visible = false;
            StatPanel.Visible = false;
            Pit_File_Mode_Panel.Visible = false;
           

        }

        //save statistics info in achosen directory
        private void PDFbutton_Click(object sender, EventArgs e)
        {
            
            System.IO.FileStream fs;
            if (PDFbutton.Text == "Save")
            {
                PDFbutton.Text = "Update";
                PDFbutton.TextAlign = ContentAlignment.MiddleCenter;
                PDFtime = DateTime.Now.ToString();
                PDFtime = PDFtime.Replace(" ", "_");
                PDFtime = PDFtime.Replace("/", "_");
                PDFtime = PDFtime.Replace(":", "_");
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (!Directory.Exists(folderBrowserDialog1.SelectedPath + @"/" + PDFtime + @"/"))
                    {
                        Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + @"/" + PDFtime + @"/");
                    }

                    PDFpath = folderBrowserDialog1.SelectedPath + @"/" + PDFtime + @"/" + "parameters.pdf";
                    Document dc = new Document(PageSize.LETTER, 40, 40, 42, 35);
                    fs = System.IO.File.Create(PDFpath);
                    PdfAWriter.GetInstance(dc, fs);
                    dc.Open();
                    dc.Add(new Paragraph(OutputTextBox.Text));
                    dc.Close();

                    System.IO.File.Copy(@PathOfPitPopulation + @"statistics/stat.xml", folderBrowserDialog1.SelectedPath + @"/" + PDFtime + @"/stat.xml");
                }

            }
            StatisticsChart.SaveImage(folderBrowserDialog1.SelectedPath + @"/" + PDFtime + @"/" + ChartcomboBox.SelectedItem.ToString().Replace(" ", "_") + ".jpeg", ChartImageFormat.Jpeg);
        }

        //configure chart 
        private void ChartcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            StatisticsChart.Visible = true;
            PDFbutton.Enabled = true;
            switch (ChartcomboBox.SelectedIndex)
            {
                case 0:
                    StatisticsChart.Series["Fault Pits"].Enabled = false;
                    StatisticsChart.Series["Average Fitness"].Enabled = false;
                    StatisticsChart.Series["Convergence"].Enabled = false;
                    StatisticsChart.Series["Invalid Pits"].Enabled = true;
                    break;
                case 1:
                    StatisticsChart.Series["Convergence"].Enabled = true;
                    StatisticsChart.Series["Invalid Pits"].Enabled = false;
                    StatisticsChart.Series["Average Fitness"].Enabled = false;
                    StatisticsChart.Series["Fault Pits"].Enabled = false;
                    break;
                case 2:
                    StatisticsChart.Series["Average Fitness"].Enabled = true;
                    StatisticsChart.Series["Invalid Pits"].Enabled = false;
                    StatisticsChart.Series["Convergence"].Enabled = false;
                    StatisticsChart.Series["Fault Pits"].Enabled = false;
                    break;
                case 3:
                    StatisticsChart.Series["Fault Pits"].Enabled = true;
                    StatisticsChart.Series["Invalid Pits"].Enabled = false;
                    StatisticsChart.Series["Convergence"].Enabled = false;
                    StatisticsChart.Series["Average Fitness"].Enabled = false;
                    break;
                case 4:
                    StatisticsChart.Series["Fault Pits"].Enabled = true;
                    StatisticsChart.Series["Invalid Pits"].Enabled = true;
                    StatisticsChart.Series["Convergence"].Enabled = true;
                    StatisticsChart.Series["Average Fitness"].Enabled = true;
                    break;

            }

        }

        //choose path by means of "Browse " button
        private void BrowseButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               PeachFuzzerPlatformTextBox.Text = opd.FileName;
            }
        }

  

    
    



     




    }
}
