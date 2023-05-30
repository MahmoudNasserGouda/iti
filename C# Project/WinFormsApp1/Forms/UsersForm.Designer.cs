namespace WinFormsApp1.Forms
{
    partial class UsersForm
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
            grdUser = new DataGridView();
            panel1 = new Panel();
            btnAddUser = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdUser).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grdUser
            // 
            grdUser.AllowUserToAddRows = false;
            grdUser.AllowUserToDeleteRows = false;
            grdUser.AllowUserToResizeRows = false;
            grdUser.BackgroundColor = Color.WhiteSmoke;
            grdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUser.Dock = DockStyle.Fill;
            grdUser.Location = new Point(0, 54);
            grdUser.Name = "grdUser";
            grdUser.RowTemplate.Height = 25;
            grdUser.Size = new Size(800, 396);
            grdUser.TabIndex = 0;
            grdUser.RowHeaderMouseDoubleClick += GrdUser_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.RoyalBlue;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(707, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(81, 30);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(12, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(331, 23);
            txtSearch.TabIndex = 1;
            txtSearch.Tag = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grdUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Users";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)grdUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView grdUser;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btnAddUser;
    }
}