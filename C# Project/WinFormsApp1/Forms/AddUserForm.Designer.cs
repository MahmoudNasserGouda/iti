namespace WinFormsApp1.Forms
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
            label4 = new Label();
            SSN = new TextBox();
            label3 = new Label();
            newusername = new TextBox();
            CreateNewUser = new Button();
            label1 = new Label();
            phonetext = new TextBox();
            Emailtext = new TextBox();
            label2 = new Label();
            label5 = new Label();
            lblAddError = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(86, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "National ID";
            // 
            // SSN
            // 
            SSN.Location = new Point(86, 169);
            SSN.Margin = new Padding(4, 3, 4, 3);
            SSN.Multiline = true;
            SSN.Name = "SSN";
            SSN.Size = new Size(262, 22);
            SSN.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(86, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "User Name";
            // 
            // newusername
            // 
            newusername.Location = new Point(86, 96);
            newusername.Margin = new Padding(4, 3, 4, 3);
            newusername.Multiline = true;
            newusername.Name = "newusername";
            newusername.Size = new Size(262, 22);
            newusername.TabIndex = 1;
            // 
            // CreateNewUser
            // 
            CreateNewUser.BackColor = Color.Green;
            CreateNewUser.FlatAppearance.BorderSize = 0;
            CreateNewUser.FlatAppearance.MouseDownBackColor = Color.White;
            CreateNewUser.FlatAppearance.MouseOverBackColor = Color.Green;
            CreateNewUser.FlatStyle = FlatStyle.Flat;
            CreateNewUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateNewUser.ForeColor = Color.Transparent;
            CreateNewUser.Location = new Point(86, 399);
            CreateNewUser.Margin = new Padding(4, 3, 4, 3);
            CreateNewUser.Name = "CreateNewUser";
            CreateNewUser.Size = new Size(262, 40);
            CreateNewUser.TabIndex = 5;
            CreateNewUser.Text = "Create ";
            CreateNewUser.UseVisualStyleBackColor = false;
            CreateNewUser.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 318);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // phonetext
            // 
            phonetext.Location = new Point(86, 237);
            phonetext.Margin = new Padding(4, 3, 4, 3);
            phonetext.Multiline = true;
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(262, 22);
            phonetext.TabIndex = 3;
            // 
            // Emailtext
            // 
            Emailtext.Location = new Point(86, 302);
            Emailtext.Margin = new Padding(4, 3, 4, 3);
            Emailtext.Multiline = true;
            Emailtext.Name = "Emailtext";
            Emailtext.Size = new Size(262, 22);
            Emailtext.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(86, 214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(86, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // lblAddError
            // 
            lblAddError.AutoSize = true;
            lblAddError.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            lblAddError.ForeColor = Color.Red;
            lblAddError.Location = new Point(86, 451);
            lblAddError.Name = "lblAddError";
            lblAddError.Size = new Size(32, 13);
            lblAddError.TabIndex = 15;
            lblAddError.Text = "Error";
            lblAddError.Visible = false;
            // 
            // adduserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(430, 519);
            Controls.Add(lblAddError);
            Controls.Add(label1);
            Controls.Add(CreateNewUser);
            Controls.Add(label4);
            Controls.Add(Emailtext);
            Controls.Add(phonetext);
            Controls.Add(SSN);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(newusername);
            Margin = new Padding(4, 3, 4, 3);
            Name = "adduserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New User";
            FormClosed += AdduserForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
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

