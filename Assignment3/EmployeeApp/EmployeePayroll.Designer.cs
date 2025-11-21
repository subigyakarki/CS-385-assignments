namespace EmployeeApp
{
    partial class EmployeePayroll
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePayroll));
            labelName = new Label();
            labelNumber = new Label();
            labelRate = new Label();
            labelHours = new Label();
            textBoxName = new TextBox();
            textBoxHour = new TextBox();
            textBoxRate = new TextBox();
            textBoxNumber = new TextBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            textBoxDisplay = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(19, 45);
            labelName.Name = "labelName";
            labelName.Size = new Size(126, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Employee Name :";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(19, 108);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(140, 20);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "Employee Number :";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Location = new Point(19, 171);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(146, 20);
            labelRate.TabIndex = 2;
            labelRate.Text = "Pay Rate ( per hour) :";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(19, 243);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(114, 20);
            labelHours.TabIndex = 3;
            labelHours.Text = "Hours Worked : ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(169, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(285, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxHour
            // 
            textBoxHour.Location = new Point(169, 236);
            textBoxHour.Name = "textBoxHour";
            textBoxHour.Size = new Size(285, 27);
            textBoxHour.TabIndex = 5;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(169, 164);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(285, 27);
            textBoxRate.TabIndex = 6;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(169, 101);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(285, 27);
            textBoxNumber.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(19, 291);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(143, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save to File";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(308, 291);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(143, 42);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "Load from File";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(514, 37);
            textBoxDisplay.Multiline = true;
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.Size = new Size(242, 295);
            textBoxDisplay.TabIndex = 10;
            // 
            // EmployeePayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(799, 380);
            Controls.Add(textBoxDisplay);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxHour);
            Controls.Add(textBoxName);
            Controls.Add(labelHours);
            Controls.Add(labelRate);
            Controls.Add(labelNumber);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EmployeePayroll";
            Text = "Employee Payroll Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelNumber;
        private Label labelRate;
        private Label labelHours;
        private TextBox textBoxName;
        private TextBox textBoxHour;
        private TextBox textBoxRate;
        private TextBox textBoxNumber;
        private Button buttonSave;
        private Button buttonLoad;
        private TextBox textBoxDisplay;
    }
}
