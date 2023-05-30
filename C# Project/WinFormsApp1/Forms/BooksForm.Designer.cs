namespace WinFormsApp1.Forms
{
    partial class BooksForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            grdBooks = new DataGridView();
            panel1 = new Panel();
            btnAddBook = new Button();
            categories = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grdBooks
            // 
            grdBooks.AllowUserToAddRows = false;
            grdBooks.AllowUserToDeleteRows = false;
            grdBooks.AllowUserToResizeRows = false;
            grdBooks.BackgroundColor = Color.WhiteSmoke;
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Dock = DockStyle.Fill;
            grdBooks.Location = new Point(0, 57);
            grdBooks.MultiSelect = false;
            grdBooks.Name = "grdBooks";
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            grdBooks.RowsDefaultCellStyle = dataGridViewCellStyle1;
            grdBooks.RowTemplate.Height = 25;
            grdBooks.Size = new Size(800, 393);
            grdBooks.TabIndex = 0;
            grdBooks.RowHeaderMouseDoubleClick += GrdBooks_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnAddBook);
            panel1.Controls.Add(categories);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBook.BackColor = Color.RoyalBlue;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(699, 12);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(89, 33);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add book ";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += BtnAddBook_Click;
            // 
            // categories
            // 
            categories.BackColor = Color.White;
            categories.DropDownStyle = ComboBoxStyle.DropDownList;
            categories.FlatStyle = FlatStyle.Flat;
            categories.FormattingEnabled = true;
            categories.Location = new Point(28, 18);
            categories.Name = "categories";
            categories.Size = new Size(192, 23);
            categories.TabIndex = 1;
            categories.SelectedIndexChanged += categories_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(236, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(203, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grdBooks);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksForm";
            Text = "Books";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView grdBooks;
        private Panel panel1;
        private ComboBox categories;
        private TextBox txtSearch;
        private Button btnAddBook;
    }
}