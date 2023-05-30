using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class adduserForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newusername = new System.Windows.Forms.TextBox();
            this.CreateNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(74, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "National ID";
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(74, 146);
            this.SSN.Multiline = true;
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(225, 20);
            this.SSN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(74, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name";
            // 
            // newusername
            // 
            this.newusername.Location = new System.Drawing.Point(74, 83);
            this.newusername.Multiline = true;
            this.newusername.Name = "newusername";
            this.newusername.Size = new System.Drawing.Size(225, 20);
            this.newusername.TabIndex = 1;
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.BackColor = System.Drawing.Color.Green;
            this.CreateNewUser.FlatAppearance.BorderSize = 0;
            this.CreateNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CreateNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.CreateNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateNewUser.ForeColor = System.Drawing.Color.Transparent;
            this.CreateNewUser.Location = new System.Drawing.Point(74, 346);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(225, 35);
            this.CreateNewUser.TabIndex = 5;
            this.CreateNewUser.Text = "Create ";
            this.CreateNewUser.UseVisualStyleBackColor = false;
            this.CreateNewUser.Click += button1_Click;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(74, 205);
            this.phonetext.Multiline = true;
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(225, 20);
            this.phonetext.TabIndex = 3;
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(74, 262);
            this.Emailtext.Multiline = true;
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(225, 20);
            this.Emailtext.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(74, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(74, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // lblAddError
            // 
            this.lblAddError.AutoSize = true;
            this.lblAddError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline);
            this.lblAddError.ForeColor = System.Drawing.Color.Red;
            this.lblAddError.Location = new System.Drawing.Point(74, 391);
            this.lblAddError.Name = "lblAddError";
            this.lblAddError.Size = new System.Drawing.Size(32, 13);
            this.lblAddError.TabIndex = 15;
            this.lblAddError.Text = "Error";
            this.lblAddError.Visible = false;
            // 
            // adduserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.lblAddError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newusername);
            this.Name = "adduserForm";
            this.FormClosed += AdduserForm_FormClosed;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox SSN;
        private Label label3;
        private TextBox newusername;
        private Button CreateNewUser;
        private Label label1;
        private TextBox phonetext;
        private TextBox Emailtext;
        private Label label2;
        private Label label5;
        private Label lblAddError;
    }
}

