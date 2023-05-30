using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            this.grdBorrowed = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBorrowed
            // 
            this.grdBorrowed.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnReturn});
            this.grdBorrowed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBorrowed.Location = new System.Drawing.Point(0, 92);
            this.grdBorrowed.Name = "grdBorrowed";
            this.grdBorrowed.RowTemplate.Height = 25;
            this.grdBorrowed.Size = new System.Drawing.Size(507, 186);
            this.grdBorrowed.TabIndex = 0;
            this.grdBorrowed.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.HeaderText = "";
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Text = "Return";
            this.btnReturn.UseColumnTextForButtonValue = true;
            this.btnReturn.Width = 70;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email :";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(277, 18);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(33, 13);
            this.lblSSN.TabIndex = 0;
            this.lblSSN.Text = "SSN :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(277, 49);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 18);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(332, 18);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.ReadOnly = true;
            this.txtSSN.Size = new System.Drawing.Size(150, 20);
            this.txtSSN.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(332, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 0;
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(507, 278);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grdBorrowed);
            this.Name = "UserDetailForm";
            this.Text = "UserDetail";
            ((System.ComponentModel.ISupportInitialize)(this.grdBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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