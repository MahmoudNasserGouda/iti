using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class AddBookForm
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
            this.BKname = new System.Windows.Forms.TextBox();
            this.BKAuthor = new System.Windows.Forms.TextBox();
            this.BKISBN = new System.Windows.Forms.TextBox();
            this.BKCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.BKDes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BKNOS = new System.Windows.Forms.NumericUpDown();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblAddError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BKNOS)).BeginInit();
            this.SuspendLayout();
            // 
            // BKname
            // 
            this.BKname.Location = new System.Drawing.Point(155, 36);
            this.BKname.Name = "BKname";
            this.BKname.Size = new System.Drawing.Size(388, 20);
            this.BKname.TabIndex = 0;
            // 
            // BKAuthor
            // 
            this.BKAuthor.Location = new System.Drawing.Point(155, 81);
            this.BKAuthor.Name = "BKAuthor";
            this.BKAuthor.Size = new System.Drawing.Size(388, 20);
            this.BKAuthor.TabIndex = 1;
            // 
            // BKISBN
            // 
            this.BKISBN.Location = new System.Drawing.Point(155, 129);
            this.BKISBN.Name = "BKISBN";
            this.BKISBN.Size = new System.Drawing.Size(388, 20);
            this.BKISBN.TabIndex = 2;
            // 
            // BKCategory
            // 
            this.BKCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BKCategory.FormattingEnabled = true;
            this.BKCategory.Location = new System.Drawing.Point(155, 175);
            this.BKCategory.Name = "BKCategory";
            this.BKCategory.Size = new System.Drawing.Size(187, 21);
            this.BKCategory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. Copies";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.Green;
            this.btnSaveAdd.FlatAppearance.BorderSize = 0;
            this.btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveAdd.Location = new System.Drawing.Point(280, 398);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(124, 40);
            this.btnSaveAdd.TabIndex = 7;
            this.btnSaveAdd.Text = "Add Book";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += BtnSaveAdd_Click;
            // 
            // BKDes
            // 
            this.BKDes.Location = new System.Drawing.Point(155, 268);
            this.BKDes.Multiline = true;
            this.BKDes.Name = "BKDes";
            this.BKDes.Size = new System.Drawing.Size(388, 57);
            this.BKDes.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description";
            // 
            // BKNOS
            // 
            this.BKNOS.Location = new System.Drawing.Point(155, 224);
            this.BKNOS.Name = "BKNOS";
            this.BKNOS.Size = new System.Drawing.Size(103, 20);
            this.BKNOS.TabIndex = 4;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(38, 362);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(37, 13);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(155, 353);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 32);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += btnBrowse_Click;
            // 
            // ofd
            // 
            this.ofd.Title = "Image";
            // 
            // lblAddError
            // 
            this.lblAddError.AutoSize = true;
            this.lblAddError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline);
            this.lblAddError.ForeColor = System.Drawing.Color.Red;
            this.lblAddError.Location = new System.Drawing.Point(280, 448);
            this.lblAddError.Name = "lblAddError";
            this.lblAddError.Size = new System.Drawing.Size(32, 13);
            this.lblAddError.TabIndex = 0;
            this.lblAddError.Text = "Error";
            this.lblAddError.Visible = false;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 477);
            this.Controls.Add(this.lblAddError);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.BKNOS);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BKCategory);
            this.Controls.Add(this.BKDes);
            this.Controls.Add(this.BKISBN);
            this.Controls.Add(this.BKAuthor);
            this.Controls.Add(this.BKname);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.BKNOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BKname;
        private TextBox BKAuthor;
        private TextBox BKISBN;
        private ComboBox BKCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSaveAdd;
        private TextBox BKDes;
        private Label label6;
        private NumericUpDown BKNOS;
        private Label lblImage;
        private Button btnBrowse;
        private OpenFileDialog ofd;
        private Label lblAddError;
    }
}