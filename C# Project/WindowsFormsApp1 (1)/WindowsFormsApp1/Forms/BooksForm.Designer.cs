using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.AllowUserToDeleteRows = false;
            this.grdBooks.AllowUserToResizeRows = false;
            this.grdBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBooks.Location = new System.Drawing.Point(0, 49);
            this.grdBooks.MultiSelect = false;
            this.grdBooks.Name = "grdBooks";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdBooks.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBooks.RowTemplate.Height = 25;
            this.grdBooks.Size = new System.Drawing.Size(686, 341);
            this.grdBooks.TabIndex = 0;
            this.grdBooks.RowHeaderMouseDoubleClick += GrdBooks_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.categories);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(599, 10);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(76, 29);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add book ";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += BtnAddBook_Click;
            // 
            // categories
            // 
            this.categories.BackColor = System.Drawing.Color.White;
            this.categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(24, 16);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(165, 21);
            this.categories.TabIndex = 1;
            this.categories.SelectedIndexChanged += categories_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(202, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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