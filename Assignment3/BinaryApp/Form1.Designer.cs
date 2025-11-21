namespace BinaryApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelIntstruction = new Label();
            textBoxNumbers = new TextBox();
            buttonAdd = new Button();
            Load = new Button();
            buttonSave = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // labelIntstruction
            // 
            labelIntstruction.AutoSize = true;
            labelIntstruction.Location = new Point(20, 43);
            labelIntstruction.Name = "labelIntstruction";
            labelIntstruction.Size = new Size(261, 20);
            labelIntstruction.TabIndex = 0;
            labelIntstruction.Text = "Enter 5 numbers seperated by spaces :";
            // 
            // textBoxNumbers
            // 
            textBoxNumbers.Location = new Point(287, 40);
            textBoxNumbers.Name = "textBoxNumbers";
            textBoxNumbers.Size = new Size(239, 27);
            textBoxNumbers.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(29, 100);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add Set";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Load
            // 
            Load.Location = new Point(421, 100);
            Load.Name = "Load";
            Load.Size = new Size(105, 46);
            Load.TabIndex = 3;
            Load.Text = "Load File";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(208, 100);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 46);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save File";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(94, 202);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(347, 164);
            listBoxResults.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(576, 450);
            Controls.Add(listBoxResults);
            Controls.Add(buttonSave);
            Controls.Add(Load);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxNumbers);
            Controls.Add(labelIntstruction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Number Set Binary App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIntstruction;
        private TextBox textBoxNumbers;
        private Button buttonAdd;
        private Button Load;
        private Button buttonSave;
        private ListBox listBoxResults;
    }
}
