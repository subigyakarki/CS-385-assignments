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
            groupBoxHousing = new GroupBox();
            radioButtonMultiUnit = new RadioButton();
            radioButtonSingleFamily = new RadioButton();
            textBoxAddress = new TextBox();
            Rent = new TextBox();
            textBoxNumofUnits = new TextBox();
            textBoxSquareFeet = new TextBox();
            textBoxYearBuilt = new TextBox();
            labelAddress = new Label();
            labelProjectedRent = new Label();
            labelRent = new Label();
            labelNumOfUnits = new Label();
            labelSquarefeet = new Label();
            labelYearBuilt = new Label();
            textBoxProjectedRent = new TextBox();
            checkBoxGarage = new CheckBox();
            buttonCalculate = new Button();
            groupBoxHousing.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHousing
            // 
            groupBoxHousing.BackColor = SystemColors.Window;
            groupBoxHousing.Controls.Add(radioButtonMultiUnit);
            groupBoxHousing.Controls.Add(radioButtonSingleFamily);
            groupBoxHousing.Location = new Point(12, 21);
            groupBoxHousing.Name = "groupBoxHousing";
            groupBoxHousing.Size = new Size(217, 104);
            groupBoxHousing.TabIndex = 0;
            groupBoxHousing.TabStop = false;
            groupBoxHousing.Text = "Select Housing Type";
            // 
            // radioButtonMultiUnit
            // 
            radioButtonMultiUnit.AutoSize = true;
            radioButtonMultiUnit.Location = new Point(6, 56);
            radioButtonMultiUnit.Name = "radioButtonMultiUnit";
            radioButtonMultiUnit.Size = new Size(95, 24);
            radioButtonMultiUnit.TabIndex = 1;
            radioButtonMultiUnit.TabStop = true;
            radioButtonMultiUnit.Text = "Multi Unit";
            radioButtonMultiUnit.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleFamily
            // 
            radioButtonSingleFamily.AutoSize = true;
            radioButtonSingleFamily.Location = new Point(6, 26);
            radioButtonSingleFamily.Name = "radioButtonSingleFamily";
            radioButtonSingleFamily.Size = new Size(117, 24);
            radioButtonSingleFamily.TabIndex = 0;
            radioButtonSingleFamily.TabStop = true;
            radioButtonSingleFamily.Text = "Single Family";
            radioButtonSingleFamily.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(143, 144);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(252, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // Rent
            // 
            Rent.Location = new Point(143, 311);
            Rent.Name = "Rent";
            Rent.Size = new Size(252, 27);
            Rent.TabIndex = 2;
            // 
            // textBoxNumofUnits
            // 
            textBoxNumofUnits.Location = new Point(143, 278);
            textBoxNumofUnits.Name = "textBoxNumofUnits";
            textBoxNumofUnits.Size = new Size(252, 27);
            textBoxNumofUnits.TabIndex = 3;
            // 
            // textBoxSquareFeet
            // 
            textBoxSquareFeet.Location = new Point(143, 212);
            textBoxSquareFeet.Name = "textBoxSquareFeet";
            textBoxSquareFeet.Size = new Size(252, 27);
            textBoxSquareFeet.TabIndex = 5;
            // 
            // textBoxYearBuilt
            // 
            textBoxYearBuilt.Location = new Point(143, 179);
            textBoxYearBuilt.Name = "textBoxYearBuilt";
            textBoxYearBuilt.Size = new Size(252, 27);
            textBoxYearBuilt.TabIndex = 6;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(18, 147);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(69, 20);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address :";
            // 
            // labelProjectedRent
            // 
            labelProjectedRent.AutoSize = true;
            labelProjectedRent.Location = new Point(519, 105);
            labelProjectedRent.Name = "labelProjectedRent";
            labelProjectedRent.Size = new Size(179, 20);
            labelProjectedRent.TabIndex = 8;
            labelProjectedRent.Text = "Projected Rental Amount ";
            // 
            // labelRent
            // 
            labelRent.AutoSize = true;
            labelRent.Location = new Point(18, 314);
            labelRent.Name = "labelRent";
            labelRent.Size = new Size(103, 20);
            labelRent.TabIndex = 9;
            labelRent.Text = "Rent per Unit :";
            // 
            // labelNumOfUnits
            // 
            labelNumOfUnits.AutoSize = true;
            labelNumOfUnits.Location = new Point(18, 281);
            labelNumOfUnits.Name = "labelNumOfUnits";
            labelNumOfUnits.Size = new Size(129, 20);
            labelNumOfUnits.TabIndex = 10;
            labelNumOfUnits.Text = "Number of Units : ";
            // 
            // labelSquarefeet
            // 
            labelSquarefeet.AutoSize = true;
            labelSquarefeet.Location = new Point(18, 215);
            labelSquarefeet.Name = "labelSquarefeet";
            labelSquarefeet.Size = new Size(94, 20);
            labelSquarefeet.TabIndex = 12;
            labelSquarefeet.Text = "Square Feet :";
            // 
            // labelYearBuilt
            // 
            labelYearBuilt.AutoSize = true;
            labelYearBuilt.Location = new Point(18, 182);
            labelYearBuilt.Name = "labelYearBuilt";
            labelYearBuilt.Size = new Size(78, 20);
            labelYearBuilt.TabIndex = 13;
            labelYearBuilt.Text = "Year Built :";
            // 
            // textBoxProjectedRent
            // 
            textBoxProjectedRent.Location = new Point(471, 140);
            textBoxProjectedRent.Name = "textBoxProjectedRent";
            textBoxProjectedRent.Size = new Size(252, 27);
            textBoxProjectedRent.TabIndex = 14;
            // 
            // checkBoxGarage
            // 
            checkBoxGarage.AutoSize = true;
            checkBoxGarage.Location = new Point(18, 248);
            checkBoxGarage.Name = "checkBoxGarage";
            checkBoxGarage.Size = new Size(119, 24);
            checkBoxGarage.TabIndex = 15;
            checkBoxGarage.Text = "Has Garage ?";
            checkBoxGarage.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 372);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(198, 42);
            buttonCalculate.TabIndex = 16;
            buttonCalculate.Text = "Calculate Rental Amount";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // PresentationGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalculate);
            Controls.Add(checkBoxGarage);
            Controls.Add(textBoxProjectedRent);
            Controls.Add(labelYearBuilt);
            Controls.Add(labelSquarefeet);
            Controls.Add(labelNumOfUnits);
            Controls.Add(labelRent);
            Controls.Add(labelProjectedRent);
            Controls.Add(labelAddress);
            Controls.Add(textBoxYearBuilt);
            Controls.Add(textBoxSquareFeet);
            Controls.Add(textBoxNumofUnits);
            Controls.Add(Rent);
            Controls.Add(textBoxAddress);
            Controls.Add(groupBoxHousing);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PresentationGUI";
            Text = "Housing Application";
            groupBoxHousing.ResumeLayout(false);
            groupBoxHousing.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxHousing;
        private RadioButton radioButtonMultiUnit;
        private RadioButton radioButtonSingleFamily;
        private TextBox textBoxAddress;
        private TextBox Rent;
        private TextBox textBoxNumofUnits;
        private TextBox textBoxSquareFeet;
        private TextBox textBoxYearBuilt;
        private Label labelAddress;
        private Label labelProjectedRent;
        private Label labelRent;
        private Label labelNumOfUnits;
        private Label labelSquarefeet;
        private Label labelYearBuilt;
        private TextBox textBoxProjectedRent;
        private CheckBox checkBoxGarage;
        private Button buttonCalculate;
    }
}
