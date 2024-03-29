﻿namespace TardyLogger
{
    partial class TardyLoggerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TardyLoggerForm));
            this.morningRadio = new System.Windows.Forms.RadioButton();
            this.passingRadio = new System.Windows.Forms.RadioButton();
            this.hallRadio = new System.Windows.Forms.RadioButton();
            this.PrintButton = new System.Windows.Forms.Button();
            this.studentsSearch = new System.Windows.Forms.DataGridView();
            this.gradeSelect = new System.Windows.Forms.ComboBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.homeroom = new System.Windows.Forms.ComboBox();
            this.homeroomLabel = new System.Windows.Forms.Label();
            this.printLog = new System.Windows.Forms.ListBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentId = new System.Windows.Forms.TextBox();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // morningRadio
            // 
            this.morningRadio.AutoSize = true;
            this.morningRadio.Checked = true;
            this.morningRadio.Location = new System.Drawing.Point(489, 9);
            this.morningRadio.Name = "morningRadio";
            this.morningRadio.Size = new System.Drawing.Size(77, 17);
            this.morningRadio.TabIndex = 0;
            this.morningRadio.TabStop = true;
            this.morningRadio.Text = "MORNING";
            this.morningRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.morningRadio.UseVisualStyleBackColor = true;
            this.morningRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // passingRadio
            // 
            this.passingRadio.AutoSize = true;
            this.passingRadio.BackColor = System.Drawing.SystemColors.Control;
            this.passingRadio.Location = new System.Drawing.Point(489, 32);
            this.passingRadio.Name = "passingRadio";
            this.passingRadio.Size = new System.Drawing.Size(123, 17);
            this.passingRadio.TabIndex = 1;
            this.passingRadio.Text = "PASSING PERIODS";
            this.passingRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passingRadio.UseVisualStyleBackColor = true;
            this.passingRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // hallRadio
            // 
            this.hallRadio.AutoSize = true;
            this.hallRadio.BackColor = System.Drawing.SystemColors.Control;
            this.hallRadio.Location = new System.Drawing.Point(489, 55);
            this.hallRadio.Name = "hallRadio";
            this.hallRadio.Size = new System.Drawing.Size(83, 17);
            this.hallRadio.TabIndex = 18;
            this.hallRadio.Text = "HALL PASS";
            this.hallRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hallRadio.UseVisualStyleBackColor = true;
            this.hallRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.Location = new System.Drawing.Point(889, 12);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "LOG/PRINT";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // studentsSearch
            // 
            this.studentsSearch.AllowDrop = true;
            this.studentsSearch.AllowUserToAddRows = false;
            this.studentsSearch.AllowUserToDeleteRows = false;
            this.studentsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.studentsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.studentsSearch.Location = new System.Drawing.Point(12, 91);
            this.studentsSearch.Name = "studentsSearch";
            this.studentsSearch.ReadOnly = true;
            this.studentsSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsSearch.Size = new System.Drawing.Size(700, 534);
            this.studentsSearch.TabIndex = 8;
            // 
            // gradeSelect
            // 
            this.gradeSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gradeSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gradeSelect.FormattingEnabled = true;
            this.gradeSelect.Items.AddRange(new object[] {
            "-ALL-"});
            this.gradeSelect.Location = new System.Drawing.Point(12, 64);
            this.gradeSelect.Name = "gradeSelect";
            this.gradeSelect.Size = new System.Drawing.Size(64, 21);
            this.gradeSelect.Sorted = true;
            this.gradeSelect.TabIndex = 9;
            this.gradeSelect.Text = "-ALL-";
            this.gradeSelect.SelectedIndexChanged += new System.EventHandler(this.gradeSelect_SelectedIndexChanged);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(92, 9);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.studentNameLabel.TabIndex = 10;
            this.studentNameLabel.Text = "Student Name";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(95, 25);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(207, 20);
            this.nameSearch.TabIndex = 11;
            this.nameSearch.TextChanged += new System.EventHandler(this.nameSearch_TextChanged);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(9, 48);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 12;
            this.gradeLabel.Text = "Grade";
            // 
            // homeroom
            // 
            this.homeroom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.homeroom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.homeroom.FormattingEnabled = true;
            this.homeroom.Items.AddRange(new object[] {
            "-ALL-"});
            this.homeroom.Location = new System.Drawing.Point(82, 64);
            this.homeroom.Name = "homeroom";
            this.homeroom.Size = new System.Drawing.Size(121, 21);
            this.homeroom.Sorted = true;
            this.homeroom.TabIndex = 13;
            this.homeroom.Text = "-ALL-";
            this.homeroom.SelectedIndexChanged += new System.EventHandler(this.homeroom_SelectedIndexChanged);
            // 
            // homeroomLabel
            // 
            this.homeroomLabel.AutoSize = true;
            this.homeroomLabel.Location = new System.Drawing.Point(79, 48);
            this.homeroomLabel.Name = "homeroomLabel";
            this.homeroomLabel.Size = new System.Drawing.Size(58, 13);
            this.homeroomLabel.TabIndex = 14;
            this.homeroomLabel.Text = "Homeroom";
            // 
            // printLog
            // 
            this.printLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printLog.FormattingEnabled = true;
            this.printLog.Location = new System.Drawing.Point(718, 90);
            this.printLog.Name = "printLog";
            this.printLog.Size = new System.Drawing.Size(246, 537);
            this.printLog.TabIndex = 15;
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(12, 25);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(77, 20);
            this.studentId.TabIndex = 16;
            this.studentId.TextChanged += new System.EventHandler(this.studentId_TextChanged);
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(9, 9);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 17;
            this.studentIdLabel.Text = "Student ID";
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(629, 25);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(187, 20);
            this.fromInput.TabIndex = 19;
            this.fromInput.Visible = false;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(626, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 20;
            this.fromLabel.Text = "From";
            this.fromLabel.Visible = false;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(626, 48);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 21;
            this.toLabel.Text = "To";
            this.toLabel.Visible = false;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(629, 64);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(187, 20);
            this.toInput.TabIndex = 22;
            this.toInput.Visible = false;
            // 
            // TardyLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 637);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.hallRadio);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.printLog);
            this.Controls.Add(this.homeroomLabel);
            this.Controls.Add(this.homeroom);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.gradeSelect);
            this.Controls.Add(this.studentsSearch);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.passingRadio);
            this.Controls.Add(this.morningRadio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TardyLoggerForm";
            this.Text = "Farrell B. Howell ECE-8 School Tardy Pass System";
            this.Load += new System.EventHandler(this.TardyLogger_load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton morningRadio;
        private System.Windows.Forms.RadioButton passingRadio;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView studentsSearch;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.ComboBox homeroom;
        private System.Windows.Forms.Label homeroomLabel;
        private System.Windows.Forms.ComboBox gradeSelect;
        private System.Windows.Forms.ListBox printLog;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.RadioButton hallRadio;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toInput;
    }
}

