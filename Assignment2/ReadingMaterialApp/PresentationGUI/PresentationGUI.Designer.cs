
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
            grpBxSelectReading = new GroupBox();
            radOnline = new RadioButton();
            radMagazine = new RadioButton();
            radBook = new RadioButton();
            bttnShowDetail = new Button();
            txtBxTitle = new TextBox();
            txtBxAuthor = new TextBox();
            txtBxYear = new TextBox();
            txtBxExtra = new TextBox();
            txtBxPrint = new TextBox();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblYearPublished = new Label();
            lblExtra = new Label();
            lblPrint = new Label();
            grpBxSelectReading.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxSelectReading
            // 
            grpBxSelectReading.BackColor = Color.FloralWhite;
            grpBxSelectReading.Controls.Add(radOnline);
            grpBxSelectReading.Controls.Add(radMagazine);
            grpBxSelectReading.Controls.Add(radBook);
            grpBxSelectReading.Location = new Point(53, 34);
            grpBxSelectReading.Name = "grpBxSelectReading";
            grpBxSelectReading.Size = new Size(288, 158);
            grpBxSelectReading.TabIndex = 0;
            grpBxSelectReading.TabStop = false;
            grpBxSelectReading.Text = "Select Reading Material";
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Location = new Point(24, 97);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(73, 24);
            radOnline.TabIndex = 2;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            // 
            // radMagazine
            // 
            radMagazine.AutoSize = true;
            radMagazine.Location = new Point(24, 67);
            radMagazine.Name = "radMagazine";
            radMagazine.Size = new Size(95, 24);
            radMagazine.TabIndex = 1;
            radMagazine.TabStop = true;
            radMagazine.Text = "Magazine";
            radMagazine.UseVisualStyleBackColor = true;
            // 
            // radBook
            // 
            radBook.AutoSize = true;
            radBook.Location = new Point(24, 37);
            radBook.Name = "radBook";
            radBook.Size = new Size(70, 24);
            radBook.TabIndex = 0;
            radBook.TabStop = true;
            radBook.Text = "Books";
            radBook.UseVisualStyleBackColor = true;
            // 
            // bttnShowDetail
            // 
            bttnShowDetail.BackColor = Color.FloralWhite;
            bttnShowDetail.Location = new Point(53, 198);
            bttnShowDetail.Name = "bttnShowDetail";
            bttnShowDetail.Size = new Size(106, 33);
            bttnShowDetail.TabIndex = 1;
            bttnShowDetail.Text = "Show Details";
            bttnShowDetail.UseVisualStyleBackColor = false;
            bttnShowDetail.Click += bttnShowDetail_Click;
            // 
            // txtBxTitle
            // 
            txtBxTitle.BackColor = Color.FloralWhite;
            txtBxTitle.Location = new Point(144, 255);
            txtBxTitle.Name = "txtBxTitle";
            txtBxTitle.ReadOnly = true;
            txtBxTitle.Size = new Size(299, 27);
            txtBxTitle.TabIndex = 2;
            // 
            // txtBxAuthor
            // 
            txtBxAuthor.BackColor = Color.FloralWhite;
            txtBxAuthor.Location = new Point(144, 288);
            txtBxAuthor.Name = "txtBxAuthor";
            txtBxAuthor.ReadOnly = true;
            txtBxAuthor.Size = new Size(299, 27);
            txtBxAuthor.TabIndex = 3;
            // 
            // txtBxYear
            // 
            txtBxYear.BackColor = Color.FloralWhite;
            txtBxYear.Location = new Point(144, 321);
            txtBxYear.Name = "txtBxYear";
            txtBxYear.ReadOnly = true;
            txtBxYear.Size = new Size(299, 27);
            txtBxYear.TabIndex = 4;
            // 
            // txtBxExtra
            // 
            txtBxExtra.BackColor = Color.FloralWhite;
            txtBxExtra.Location = new Point(144, 354);
            txtBxExtra.Name = "txtBxExtra";
            txtBxExtra.ReadOnly = true;
            txtBxExtra.Size = new Size(299, 27);
            txtBxExtra.TabIndex = 5;
            // 
            // txtBxPrint
            // 
            txtBxPrint.BackColor = Color.FloralWhite;
            txtBxPrint.Location = new Point(144, 387);
            txtBxPrint.Name = "txtBxPrint";
            txtBxPrint.ReadOnly = true;
            txtBxPrint.Size = new Size(299, 27);
            txtBxPrint.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(29, 258);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 20);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(29, 291);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 20);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author :";
            // 
            // lblYearPublished
            // 
            lblYearPublished.AutoSize = true;
            lblYearPublished.Location = new Point(29, 324);
            lblYearPublished.Name = "lblYearPublished";
            lblYearPublished.Size = new Size(112, 20);
            lblYearPublished.TabIndex = 9;
            lblYearPublished.Text = "Year Published :";
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(29, 357);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(83, 20);
            lblExtra.TabIndex = 10;
            lblExtra.Text = "Extra Info : ";
            // 
            // lblPrint
            // 
            lblPrint.AutoSize = true;
            lblPrint.Location = new Point(29, 390);
            lblPrint.Name = "lblPrint";
            lblPrint.Size = new Size(76, 20);
            lblPrint.TabIndex = 11;
            lblPrint.Text = "Print Info :";
            // 
            // PresentationGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(616, 450);
            Controls.Add(lblPrint);
            Controls.Add(lblExtra);
            Controls.Add(lblYearPublished);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(txtBxPrint);
            Controls.Add(txtBxExtra);
            Controls.Add(txtBxYear);
            Controls.Add(txtBxAuthor);
            Controls.Add(txtBxTitle);
            Controls.Add(bttnShowDetail);
            Controls.Add(grpBxSelectReading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PresentationGUI";
            Text = "Reading Material App";
            grpBxSelectReading.ResumeLayout(false);
            grpBxSelectReading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BttnShowDetail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox grpBxSelectReading;
        private RadioButton radOnline;
        private RadioButton radMagazine;
        private RadioButton radBook;
        private Button bttnShowDetail;
        private TextBox txtBxTitle;
        private TextBox txtBxAuthor;
        private TextBox txtBxYear;
        private TextBox txtBxExtra;
        private TextBox txtBxPrint;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblYearPublished;
        private Label lblExtra;
        private Label lblPrint;
    }
}
