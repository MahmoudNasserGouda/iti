using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.nudPeriod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPeriod.Location = new System.Drawing.Point(11, 51);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(96, 20);
            this.lblPeriod.TabIndex = 0;
            this.lblPeriod.Text = "Period (Day)";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(11, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(150, 9);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(113, 21);
            this.cbUser.TabIndex = 1;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Green;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(96, 122);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(79, 32);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += btnBorrow_Click;
            // 
            // nudPeriod
            // 
            this.nudPeriod.Location = new System.Drawing.Point(150, 53);
            this.nudPeriod.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeriod.Name = "nudPeriod";
            this.nudPeriod.Size = new System.Drawing.Size(112, 20);
            this.nudPeriod.TabIndex = 2;
            this.nudPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BorrowingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(287, 175);
            this.Controls.Add(this.nudPeriod);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblUser);
            this.Name = "BorrowingBookForm";
            this.Text = "Borrowing Book";
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPeriod;
        private Label lblUser;
        private ComboBox cbUser;
        private Button btnBorrow;
        private NumericUpDown nudPeriod;
    }
}

