namespace WinFormsApp1.Forms
{
    partial class AdminForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lblErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(61, 368);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(262, 40);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 0;
            label1.Text = "Login Your Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 176);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(61, 232);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 22);
            txtUserName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(56, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(61, 305);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 22);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(56, 280);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.kindpng_2351000;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(124, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(61, 421);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(32, 13);
            lblErrorMessage.TabIndex = 0;
            lblErrorMessage.Text = "Error";
            lblErrorMessage.Visible = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(391, 524);
            Controls.Add(lblErrorMessage);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lblErrorMessage;
    }
}

