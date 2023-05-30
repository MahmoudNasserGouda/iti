namespace WinFormsApp1.Forms
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
            BKname = new TextBox();
            BKAuthor = new TextBox();
            BKISBN = new TextBox();
            BKCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSaveAdd = new Button();
            BKDes = new TextBox();
            label6 = new Label();
            BKNOS = new NumericUpDown();
            lblImage = new Label();
            btnBrowse = new Button();
            ofd = new OpenFileDialog();
            lblAddError = new Label();
            ((System.ComponentModel.ISupportInitialize)BKNOS).BeginInit();
            SuspendLayout();
            // 
            // BKname
            // 
            BKname.Location = new Point(181, 41);
            BKname.Name = "BKname";
            BKname.Size = new Size(452, 23);
            BKname.TabIndex = 0;
            // 
            // BKAuthor
            // 
            BKAuthor.Location = new Point(181, 94);
            BKAuthor.Name = "BKAuthor";
            BKAuthor.Size = new Size(452, 23);
            BKAuthor.TabIndex = 1;
            // 
            // BKISBN
            // 
            BKISBN.Location = new Point(181, 149);
            BKISBN.Name = "BKISBN";
            BKISBN.Size = new Size(452, 23);
            BKISBN.TabIndex = 2;
            // 
            // BKCategory
            // 
            BKCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            BKCategory.FormattingEnabled = true;
            BKCategory.Location = new Point(181, 202);
            BKCategory.Name = "BKCategory";
            BKCategory.Size = new Size(217, 23);
            BKCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 97);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 152);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 205);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 260);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "No. Copies";
            // 
            // btnSaveAdd
            // 
            btnSaveAdd.BackColor = Color.Green;
            btnSaveAdd.FlatAppearance.BorderSize = 0;
            btnSaveAdd.FlatStyle = FlatStyle.Flat;
            btnSaveAdd.ForeColor = Color.Transparent;
            btnSaveAdd.Location = new Point(327, 459);
            btnSaveAdd.Name = "btnSaveAdd";
            btnSaveAdd.Size = new Size(145, 46);
            btnSaveAdd.TabIndex = 7;
            btnSaveAdd.Text = "Add Book";
            btnSaveAdd.UseVisualStyleBackColor = false;
            btnSaveAdd.Click += BtnSaveAdd_Click;
            // 
            // BKDes
            // 
            BKDes.Location = new Point(181, 309);
            BKDes.Multiline = true;
            BKDes.Name = "BKDes";
            BKDes.Size = new Size(452, 65);
            BKDes.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 330);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Description";
            // 
            // BKNOS
            // 
            BKNOS.Location = new Point(181, 258);
            BKNOS.Name = "BKNOS";
            BKNOS.Size = new Size(120, 23);
            BKNOS.TabIndex = 4;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(44, 418);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(40, 15);
            lblImage.TabIndex = 0;
            lblImage.Text = "Image";
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(181, 407);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(82, 37);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // ofd
            // 
            ofd.Title = "Image";
            // 
            // lblAddError
            // 
            lblAddError.AutoSize = true;
            lblAddError.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            lblAddError.ForeColor = Color.Red;
            lblAddError.Location = new Point(327, 517);
            lblAddError.Name = "lblAddError";
            lblAddError.Size = new Size(32, 13);
            lblAddError.TabIndex = 0;
            lblAddError.Text = "Error";
            lblAddError.Visible = false;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 550);
            Controls.Add(lblAddError);
            Controls.Add(btnBrowse);
            Controls.Add(lblImage);
            Controls.Add(BKNOS);
            Controls.Add(btnSaveAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BKCategory);
            Controls.Add(BKDes);
            Controls.Add(BKISBN);
            Controls.Add(BKAuthor);
            Controls.Add(BKname);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)BKNOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
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