using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace peach_project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mode_ComboBox.Text == "Pit File Citizens")
            {
                Modified_Input_Panel.Visible = false;
                Pit_File_Mode_Panel.Visible = true;

            }
            else if (Mode_ComboBox.Text == "Modified Input Citizens")
            {

                Modified_Input_Panel.Visible = true;
                Pit_File_Mode_Panel.Visible = true;
            }

        }
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Mode_ComboBox.SelectedIndex = 0;
            //disable controls to avoid user actions while running
            DisableControls(Pit_File_Mode_Panel);
            //check parameters
            if (!paramCheck(Pit_File_Mode_Panel))
            {
                MessageBox.Show("Incorrect parameters. Check your data.");
                SetDefaultValues();
                return;
            }

            //get parameters
            String PitFilePath = PitFilePathTextBox.Text.ToString();
            String logsPath = PathSaveLogsTextBox.Text.ToString();
            String PathOfPitPopulation = PathSavePopTextBox.Text.ToString();
            int population = Convert.ToInt32(PopNumberComboBox.SelectedItem.ToString());
            String PeachTestRange = PeachTestRangeTestBox.Text.ToString();

            //start program
            PitFileMode.PitFileMode_main(logsPath, population, PathOfPitPopulation, PitFilePath, PeachTestRange);

            //enable controls and return to the home page
            SetDefaultValues();
        }

        private void Start_Button_2_Click(object sender, EventArgs e)
        {
            Modified_Input_Panel.Visible = false;
            Pit_File_Mode_Panel.Visible = false;
            Mode_ComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void BrowseButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PitFilePathTextBox.Text = opd.FileName;
            }
        }

        private void BroeswButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathSaveLogsTextBox.Text = opd.FileName;
            }
        }

        private void BrowseButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PitFilePathTextBox.Text = fbd.SelectedPath;
            }
        }


        //==========================================================extra functions============================================================================
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

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

        private bool paramCheck(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "") return false;
                    if (c.Name == "PeachTestRangeTestBox")
                    {
                        int val;
                        if (!int.TryParse(c.Text, out val)) return false;
                    }
                
                }
            }
            return true;
        
        }
        private void SetDefaultValues()
        {
            Mode_ComboBox.SelectedIndex = 0;
            PopNumberComboBox.SelectedIndex = 0;
            PitFilePathTextBox.Text = @"C:\Users\Masha\Downloads\peach_svn\samples\wav_fuzz.xml";
            PathSaveLogsTextBox.Text = @"C:\Users\Masha\Documents\Visual Studio 2010\Projects\peach_project_\peach_project_\logs\";
            PathSavePopTextBox.Text = @"C:\Users\Masha\Downloads\peach_svn\samples\mutated\";
            Modified_Input_Panel.Visible = false;
            Pit_File_Mode_Panel.Visible = false;
            EnableControls(Pit_File_Mode_Panel);
            EnableControls(Pit_File_Mode_Panel);

        }
        //===================================================================================================================================
    }
}
