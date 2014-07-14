namespace peach_project_
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
            this.Mode_Lable = new System.Windows.Forms.Label();
            this.Mode_ComboBox = new System.Windows.Forms.ComboBox();
            this.Pit_File_Mode_Panel = new System.Windows.Forms.Panel();
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
            this.Modified_Input_Panel = new System.Windows.Forms.Panel();
            this.Start_Button_2 = new System.Windows.Forms.Button();
            this.Head_Label_2 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Head_Lable_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PeachTestRangeTestBox = new System.Windows.Forms.TextBox();
            this.Pit_File_Mode_Panel.SuspendLayout();
            this.Modified_Input_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mode_Lable
            // 
            this.Mode_Lable.AutoSize = true;
            this.Mode_Lable.Location = new System.Drawing.Point(25, 24);
            this.Mode_Lable.Name = "Mode_Lable";
            this.Mode_Lable.Size = new System.Drawing.Size(73, 13);
            this.Mode_Lable.TabIndex = 0;
            this.Mode_Lable.Text = "Choose Mode";
            // 
            // Mode_ComboBox
            // 
            this.Mode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mode_ComboBox.FormattingEnabled = true;
            this.Mode_ComboBox.Items.AddRange(new object[] {
            "None",
            "Pit File Citizens",
            "Modified Input Citizens"});
            this.Mode_ComboBox.Location = new System.Drawing.Point(145, 21);
            this.Mode_ComboBox.Name = "Mode_ComboBox";
            this.Mode_ComboBox.Size = new System.Drawing.Size(151, 21);
            this.Mode_ComboBox.TabIndex = 1;
            this.Mode_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pit_File_Mode_Panel
            // 
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
            this.Pit_File_Mode_Panel.Controls.Add(this.Modified_Input_Panel);
            this.Pit_File_Mode_Panel.Controls.Add(this.Start_Button);
            this.Pit_File_Mode_Panel.Controls.Add(this.Head_Lable_1);
            this.Pit_File_Mode_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pit_File_Mode_Panel.Location = new System.Drawing.Point(0, 0);
            this.Pit_File_Mode_Panel.Name = "Pit_File_Mode_Panel";
            this.Pit_File_Mode_Panel.Size = new System.Drawing.Size(640, 359);
            this.Pit_File_Mode_Panel.TabIndex = 3;
            this.Pit_File_Mode_Panel.Visible = false;
            // 
            // BrowseButton3
            // 
            this.BrowseButton3.Location = new System.Drawing.Point(349, 113);
            this.BrowseButton3.Name = "BrowseButton3";
            this.BrowseButton3.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton3.TabIndex = 13;
            this.BrowseButton3.Text = "Browse...";
            this.BrowseButton3.UseVisualStyleBackColor = true;
            this.BrowseButton3.Click += new System.EventHandler(this.BrowseButton3_Click);
            // 
            // BroeswButton2
            // 
            this.BroeswButton2.Location = new System.Drawing.Point(349, 79);
            this.BroeswButton2.Name = "BroeswButton2";
            this.BroeswButton2.Size = new System.Drawing.Size(75, 23);
            this.BroeswButton2.TabIndex = 12;
            this.BroeswButton2.Text = "Browse...";
            this.BroeswButton2.UseVisualStyleBackColor = true;
            this.BroeswButton2.Click += new System.EventHandler(this.BroeswButton2_Click);
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.Location = new System.Drawing.Point(349, 48);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton1.TabIndex = 11;
            this.BrowseButton1.Text = "Browse...";
            this.BrowseButton1.UseVisualStyleBackColor = true;
            this.BrowseButton1.Click += new System.EventHandler(this.BrowseButton1_Click);
            // 
            // PopNumberComboBox
            // 
            this.PopNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PopNumberComboBox.FormattingEnabled = true;
            this.PopNumberComboBox.Items.AddRange(new object[] {
            "100",
            "500",
            "1000"});
            this.PopNumberComboBox.Location = new System.Drawing.Point(185, 152);
            this.PopNumberComboBox.Name = "PopNumberComboBox";
            this.PopNumberComboBox.Size = new System.Drawing.Size(145, 21);
            this.PopNumberComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Population Number";
            // 
            // PitFilePathTextBox
            // 
            this.PitFilePathTextBox.Location = new System.Drawing.Point(185, 48);
            this.PitFilePathTextBox.Name = "PitFilePathTextBox";
            this.PitFilePathTextBox.Size = new System.Drawing.Size(145, 20);
            this.PitFilePathTextBox.TabIndex = 8;
            // 
            // PathSavePopTextBox
            // 
            this.PathSavePopTextBox.Location = new System.Drawing.Point(185, 113);
            this.PathSavePopTextBox.Name = "PathSavePopTextBox";
            this.PathSavePopTextBox.Size = new System.Drawing.Size(145, 20);
            this.PathSavePopTextBox.TabIndex = 7;
            // 
            // PathSaveLogsTextBox
            // 
            this.PathSaveLogsTextBox.Location = new System.Drawing.Point(185, 81);
            this.PathSaveLogsTextBox.Name = "PathSaveLogsTextBox";
            this.PathSaveLogsTextBox.Size = new System.Drawing.Size(145, 20);
            this.PathSaveLogsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path To Save Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path To Save Logs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Pit File Path";
            // 
            // Modified_Input_Panel
            // 
            this.Modified_Input_Panel.Controls.Add(this.Start_Button_2);
            this.Modified_Input_Panel.Controls.Add(this.Head_Label_2);
            this.Modified_Input_Panel.Location = new System.Drawing.Point(438, 216);
            this.Modified_Input_Panel.Name = "Modified_Input_Panel";
            this.Modified_Input_Panel.Size = new System.Drawing.Size(48, 52);
            this.Modified_Input_Panel.TabIndex = 2;
            this.Modified_Input_Panel.Visible = false;
            // 
            // Start_Button_2
            // 
            this.Start_Button_2.Location = new System.Drawing.Point(428, 306);
            this.Start_Button_2.Name = "Start_Button_2";
            this.Start_Button_2.Size = new System.Drawing.Size(75, 23);
            this.Start_Button_2.TabIndex = 1;
            this.Start_Button_2.Text = "Start";
            this.Start_Button_2.UseVisualStyleBackColor = true;
            this.Start_Button_2.Click += new System.EventHandler(this.Start_Button_2_Click);
            // 
            // Head_Label_2
            // 
            this.Head_Label_2.AutoSize = true;
            this.Head_Label_2.Location = new System.Drawing.Point(192, 42);
            this.Head_Label_2.Name = "Head_Label_2";
            this.Head_Label_2.Size = new System.Drawing.Size(104, 13);
            this.Head_Label_2.TabIndex = 0;
            this.Head_Label_2.Text = "Modified Input Mode";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(534, 324);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Head_Lable_1
            // 
            this.Head_Lable_1.AutoSize = true;
            this.Head_Lable_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Head_Lable_1.Location = new System.Drawing.Point(12, 11);
            this.Head_Lable_1.Name = "Head_Lable_1";
            this.Head_Lable_1.Size = new System.Drawing.Size(81, 13);
            this.Head_Lable_1.TabIndex = 0;
            this.Head_Lable_1.Text = "Pit File Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Peach Test Range";
            // 
            // PeachTestRangeTestBox
            // 
            this.PeachTestRangeTestBox.Location = new System.Drawing.Point(185, 193);
            this.PeachTestRangeTestBox.Name = "PeachTestRangeTestBox";
            this.PeachTestRangeTestBox.Size = new System.Drawing.Size(145, 20);
            this.PeachTestRangeTestBox.TabIndex = 15;
            this.PeachTestRangeTestBox.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.Pit_File_Mode_Panel);
            this.Controls.Add(this.Mode_ComboBox);
            this.Controls.Add(this.Mode_Lable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pit_File_Mode_Panel.ResumeLayout(false);
            this.Pit_File_Mode_Panel.PerformLayout();
            this.Modified_Input_Panel.ResumeLayout(false);
            this.Modified_Input_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mode_Lable;
        private System.Windows.Forms.ComboBox Mode_ComboBox;
        private System.Windows.Forms.Panel Pit_File_Mode_Panel;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Head_Lable_1;
        private System.Windows.Forms.Panel Modified_Input_Panel;
        private System.Windows.Forms.Button Start_Button_2;
        private System.Windows.Forms.Label Head_Label_2;
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
    }
}

