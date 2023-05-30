namespace WinFormsApp1.Forms
{
    partial class UserDetailForm
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
            grdBorrowed = new DataGridView();
            btnReturn = new DataGridViewButtonColumn();
            lblName = new Label();
            lblEmail = new Label();
            lblSSN = new Label();
            lblPhone = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtSSN = new TextBox();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdBorrowed).BeginInit();
            SuspendLayout();
            // 
            // grdBorrowed
            // 
            grdBorrowed.BackgroundColor = Color.WhiteSmoke;
            grdBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBorrowed.Columns.AddRange(new DataGridViewColumn[] { btnReturn });
            grdBorrowed.Dock = DockStyle.Bottom;
            grdBorrowed.Location = new Point(0, 106);
            grdBorrowed.Name = "grdBorrowed";
            grdBorrowed.RowTemplate.Height = 25;
            grdBorrowed.Size = new Size(592, 215);
            grdBorrowed.TabIndex = 0;
            grdBorrowed.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.HeaderText = "";
            btnReturn.Name = "btnReturn";
            btnReturn.Text = "Return";
            btnReturn.UseColumnTextForButtonValue = true;
            btnReturn.Width = 70;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 57);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(323, 21);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(34, 15);
            lblSSN.TabIndex = 0;
            lblSSN.Text = "SSN :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(323, 57);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(47, 15);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone :";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 21);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(174, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(387, 21);
            txtSSN.Name = "txtSSN";
            txtSSN.ReadOnly = true;
            txtSSN.Size = new Size(174, 23);
            txtSSN.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(387, 57);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(174, 23);
            txtPhone.TabIndex = 0;
            // 
            // UserDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(592, 321);
            Controls.Add(txtPhone);
            Controls.Add(txtSSN);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(lblSSN);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(grdBorrowed);
            Name = "UserDetailForm";
            Text = "UserDetail";
            ((System.ComponentModel.ISupportInitialize)grdBorrowed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView grdBorrowed;

        #endregion
        private Label lblName;
        private Label lblEmail;
        private Label lblSSN;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtSSN;
        private TextBox txtPhone;
        private DataGridViewButtonColumn btnReturn;
    }
}