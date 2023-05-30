namespace WinFormsApp1.Forms
{
    partial class EditBookForm
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
            label2 = new Label();
            btnSave = new Button();
            label5 = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            lblDescription = new Label();
            lblImage = new Label();
            lblError = new Label();
            nudTotalCopies = new NumericUpDown();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            btnBrowse = new Button();
            ofd = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nudTotalCopies).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 10);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(275, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 55);
            btnSave.TabIndex = 7;
            btnSave.Text = "SaveChanges";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 230);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 0;
            label5.Text = "Total copies :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(67, 69);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(80, 15);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Book Author :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(67, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Title :";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(191, 69);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(452, 23);
            txtAuthor.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(191, 23);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(452, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(191, 115);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(452, 96);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(67, 115);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Book description :";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(67, 327);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(46, 15);
            lblImage.TabIndex = 0;
            lblImage.Text = "Image :";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(275, 429);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 13);
            lblError.TabIndex = 0;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // nudTotalCopies
            // 
            nudTotalCopies.Location = new Point(191, 230);
            nudTotalCopies.Name = "nudTotalCopies";
            nudTotalCopies.Size = new Size(120, 23);
            nudTotalCopies.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(67, 273);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category :";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(191, 273);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(191, 327);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(685, 450);
            Controls.Add(btnBrowse);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(nudTotalCopies);
            Controls.Add(lblError);
            Controls.Add(lblImage);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Name = "EditBookForm";
            Text = "Edit Book";
            ((System.ComponentModel.ISupportInitialize)nudTotalCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnSave;
        private Label label5;
        private Label lblAuthor;
        private Label lblTitle;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private Label lblDescription;
        private Label lblImage;
        private Label lblError;
        private NumericUpDown nudTotalCopies;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Button btnBrowse;
        private OpenFileDialog ofd;
    }
}