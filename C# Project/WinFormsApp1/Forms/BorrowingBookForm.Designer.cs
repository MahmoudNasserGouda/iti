namespace WinFormsApp1.Forms
{
    partial class BorrowingBookForm
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
            lblPeriod = new Label();
            lblUser = new Label();
            cbUser = new ComboBox();
            btnBorrow = new Button();
            nudPeriod = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPeriod).BeginInit();
            SuspendLayout();
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriod.ForeColor = SystemColors.GrayText;
            lblPeriod.Location = new Point(13, 59);
            lblPeriod.Margin = new Padding(4, 0, 4, 0);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(96, 20);
            lblPeriod.TabIndex = 0;
            lblPeriod.Text = "Period (Day)";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = SystemColors.GrayText;
            lblUser.Location = new Point(13, 9);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "User";
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(175, 10);
            cbUser.Margin = new Padding(4, 3, 4, 3);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(131, 23);
            cbUser.TabIndex = 1;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.Green;
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatAppearance.MouseDownBackColor = Color.White;
            btnBorrow.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrow.ForeColor = Color.White;
            btnBorrow.Location = new Point(112, 141);
            btnBorrow.Margin = new Padding(4, 3, 4, 3);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(92, 37);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // nudPeriod
            // 
            nudPeriod.Location = new Point(175, 61);
            nudPeriod.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeriod.Name = "nudPeriod";
            nudPeriod.Size = new Size(131, 23);
            nudPeriod.TabIndex = 2;
            nudPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BorrowingBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(335, 202);
            Controls.Add(nudPeriod);
            Controls.Add(btnBorrow);
            Controls.Add(cbUser);
            Controls.Add(lblPeriod);
            Controls.Add(lblUser);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BorrowingBookForm";
            Text = "Borrowing Book";
            ((System.ComponentModel.ISupportInitialize)nudPeriod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeriod;
        private Label lblUser;
        private ComboBox cbUser;
        private Button btnBorrow;
        private NumericUpDown nudPeriod;
    }
}

