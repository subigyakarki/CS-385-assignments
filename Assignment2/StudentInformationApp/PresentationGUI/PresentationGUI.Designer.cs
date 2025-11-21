namespace PresentationGUI
{
    partial class PresentationGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentationGUI));
            groupBoxStudentType = new GroupBox();
            radGraduate = new RadioButton();
            radUnderGraduate = new RadioButton();
            textBoxName = new TextBox();
            textBox2 = new TextBox();
            textBoxGuardianAddress = new TextBox();
            textBoxGuardianName = new TextBox();
            textBoxClassification = new TextBox();
            textBoxInstitution = new TextBox();
            textBoxUGDegree = new TextBox();
            textBoxMajor = new TextBox();
            textBoxID = new TextBox();
            labelName = new Label();
            labelGuardianAddress = new Label();
            labelGuardianName = new Label();
            labelClassification = new Label();
            labelInstituion = new Label();
            labelUGDegree = new Label();
            labelMajor = new Label();
            labelID = new Label();
            buttonAddStudent = new Button();
            groupBoxStudentType.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudentType
            // 
            groupBoxStudentType.BackColor = Color.Azure;
            groupBoxStudentType.Controls.Add(radGraduate);
            groupBoxStudentType.Controls.Add(radUnderGraduate);
            groupBoxStudentType.Location = new Point(35, 26);
            groupBoxStudentType.Name = "groupBoxStudentType";
            groupBoxStudentType.Size = new Size(191, 119);
            groupBoxStudentType.TabIndex = 0;
            groupBoxStudentType.TabStop = false;
            groupBoxStudentType.Text = "Select Student Type";
            // 
            // radGraduate
            // 
            radGraduate.AutoSize = true;
            radGraduate.Location = new Point(17, 68);
            radGraduate.Name = "radGraduate";
            radGraduate.Size = new Size(91, 24);
            radGraduate.TabIndex = 1;
            radGraduate.TabStop = true;
            radGraduate.Text = "Graduate";
            radGraduate.UseVisualStyleBackColor = true;
            // 
            // radUnderGraduate
            // 
            radUnderGraduate.AutoSize = true;
            radUnderGraduate.Location = new Point(17, 38);
            radUnderGraduate.Name = "radUnderGraduate";
            radUnderGraduate.Size = new Size(130, 24);
            radUnderGraduate.TabIndex = 0;
            radUnderGraduate.TabStop = true;
            radUnderGraduate.Text = "Undergraduate";
            radUnderGraduate.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Azure;
            textBoxName.Location = new Point(93, 159);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(310, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Azure;
            textBox2.Location = new Point(477, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(245, 323);
            textBox2.TabIndex = 2;
            // 
            // textBoxGuardianAddress
            // 
            textBoxGuardianAddress.BackColor = Color.Azure;
            textBoxGuardianAddress.Location = new Point(210, 390);
            textBoxGuardianAddress.Name = "textBoxGuardianAddress";
            textBoxGuardianAddress.Size = new Size(193, 27);
            textBoxGuardianAddress.TabIndex = 3;
            // 
            // textBoxGuardianName
            // 
            textBoxGuardianName.BackColor = Color.Azure;
            textBoxGuardianName.Location = new Point(210, 357);
            textBoxGuardianName.Name = "textBoxGuardianName";
            textBoxGuardianName.Size = new Size(193, 27);
            textBoxGuardianName.TabIndex = 4;
            // 
            // textBoxClassification
            // 
            textBoxClassification.BackColor = Color.Azure;
            textBoxClassification.Location = new Point(210, 324);
            textBoxClassification.Name = "textBoxClassification";
            textBoxClassification.Size = new Size(193, 27);
            textBoxClassification.TabIndex = 5;
            // 
            // textBoxInstitution
            // 
            textBoxInstitution.BackColor = Color.Azure;
            textBoxInstitution.Location = new Point(210, 291);
            textBoxInstitution.Name = "textBoxInstitution";
            textBoxInstitution.Size = new Size(193, 27);
            textBoxInstitution.TabIndex = 6;
            // 
            // textBoxUGDegree
            // 
            textBoxUGDegree.BackColor = Color.Azure;
            textBoxUGDegree.Location = new Point(210, 258);
            textBoxUGDegree.Name = "textBoxUGDegree";
            textBoxUGDegree.Size = new Size(193, 27);
            textBoxUGDegree.TabIndex = 7;
            // 
            // textBoxMajor
            // 
            textBoxMajor.BackColor = Color.Azure;
            textBoxMajor.Location = new Point(92, 225);
            textBoxMajor.Name = "textBoxMajor";
            textBoxMajor.Size = new Size(311, 27);
            textBoxMajor.TabIndex = 8;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.Azure;
            textBoxID.Location = new Point(123, 192);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(280, 27);
            textBoxID.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(19, 166);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 20);
            labelName.TabIndex = 10;
            labelName.Text = "Name :";
            // 
            // labelGuardianAddress
            // 
            labelGuardianAddress.AutoSize = true;
            labelGuardianAddress.Location = new Point(19, 397);
            labelGuardianAddress.Name = "labelGuardianAddress";
            labelGuardianAddress.Size = new Size(192, 20);
            labelGuardianAddress.TabIndex = 12;
            labelGuardianAddress.Text = "Parent / Guardian Address : ";
            // 
            // labelGuardianName
            // 
            labelGuardianName.AutoSize = true;
            labelGuardianName.Location = new Point(19, 364);
            labelGuardianName.Name = "labelGuardianName";
            labelGuardianName.Size = new Size(179, 20);
            labelGuardianName.TabIndex = 13;
            labelGuardianName.Text = "Parent / Guardian Name : ";
            // 
            // labelClassification
            // 
            labelClassification.AutoSize = true;
            labelClassification.Location = new Point(19, 331);
            labelClassification.Name = "labelClassification";
            labelClassification.Size = new Size(162, 20);
            labelClassification.TabIndex = 14;
            labelClassification.Text = "Student Classification : ";
            // 
            // labelInstituion
            // 
            labelInstituion.AutoSize = true;
            labelInstituion.Location = new Point(19, 298);
            labelInstituion.Name = "labelInstituion";
            labelInstituion.Size = new Size(161, 20);
            labelInstituion.TabIndex = 15;
            labelInstituion.Text = "Location of Institution :";
            // 
            // labelUGDegree
            // 
            labelUGDegree.AutoSize = true;
            labelUGDegree.Location = new Point(19, 265);
            labelUGDegree.Name = "labelUGDegree";
            labelUGDegree.Size = new Size(173, 20);
            labelUGDegree.TabIndex = 16;
            labelUGDegree.Text = "Undergraduate Degree : ";
            // 
            // labelMajor
            // 
            labelMajor.AutoSize = true;
            labelMajor.Location = new Point(19, 232);
            labelMajor.Name = "labelMajor";
            labelMajor.Size = new Size(55, 20);
            labelMajor.TabIndex = 17;
            labelMajor.Text = "Major :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(19, 199);
            labelID.Name = "labelID";
            labelID.Size = new Size(86, 20);
            labelID.TabIndex = 18;
            labelID.Text = "Student ID :";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.Azure;
            buttonAddStudent.Location = new Point(29, 441);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(176, 40);
            buttonAddStudent.TabIndex = 19;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // PresentationGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 508);
            Controls.Add(buttonAddStudent);
            Controls.Add(labelID);
            Controls.Add(labelMajor);
            Controls.Add(labelUGDegree);
            Controls.Add(labelInstituion);
            Controls.Add(labelClassification);
            Controls.Add(labelGuardianName);
            Controls.Add(labelGuardianAddress);
            Controls.Add(labelName);
            Controls.Add(textBoxID);
            Controls.Add(textBoxMajor);
            Controls.Add(textBoxUGDegree);
            Controls.Add(textBoxInstitution);
            Controls.Add(textBoxClassification);
            Controls.Add(textBoxGuardianName);
            Controls.Add(textBoxGuardianAddress);
            Controls.Add(textBox2);
            Controls.Add(textBoxName);
            Controls.Add(groupBoxStudentType);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PresentationGUI";
            Text = "Student Information Display";
            groupBoxStudentType.ResumeLayout(false);
            groupBoxStudentType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxStudentType;
        private RadioButton radGraduate;
        private RadioButton radUnderGraduate;
        private TextBox textBoxName;
        private TextBox textBox2;
        private TextBox textBoxGuardianAddress;
        private TextBox textBoxGuardianName;
        private TextBox textBoxClassification;
        private TextBox textBoxInstitution;
        private TextBox textBoxUGDegree;
        private TextBox textBoxMajor;
        private TextBox textBoxID;
        private Label labelName;
        private Label labelGuardianAddress;
        private Label labelGuardianName;
        private Label labelClassification;
        private Label labelInstituion;
        private Label labelUGDegree;
        private Label labelMajor;
        private Label labelID;
        private Button buttonAddStudent;
    }
}
