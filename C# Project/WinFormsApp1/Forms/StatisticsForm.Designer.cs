namespace WinFormsApp1.Forms
{
    partial class StatisticsForm
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            resulttextbox = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textbox4 = new TextBox();
            textbox3 = new TextBox();
            textbox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textbox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(175, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(154, 27);
            button2.TabIndex = 2;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(13, 12);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(154, 27);
            button1.TabIndex = 1;
            button1.Text = "USER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImage = Properties.Resources.statistics_512;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(resulttextbox);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textbox4);
            panel2.Controls.Add(textbox3);
            panel2.Controls.Add(textbox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textbox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 398);
            panel2.TabIndex = 0;
            // 
            // resulttextbox
            // 
            resulttextbox.Location = new Point(313, 332);
            resulttextbox.Name = "resulttextbox";
            resulttextbox.ReadOnly = true;
            resulttextbox.Size = new Size(100, 23);
            resulttextbox.TabIndex = 0;
            resulttextbox.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(313, 273);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 0;
            textBox5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 332);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 273);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 217);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 156);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // textbox4
            // 
            textbox4.Location = new Point(313, 209);
            textbox4.Name = "textbox4";
            textbox4.ReadOnly = true;
            textbox4.Size = new Size(100, 23);
            textbox4.TabIndex = 0;
            textbox4.Visible = false;
            // 
            // textbox3
            // 
            textbox3.Location = new Point(313, 148);
            textbox3.Name = "textbox3";
            textbox3.ReadOnly = true;
            textbox3.Size = new Size(100, 23);
            textbox3.TabIndex = 0;
            textbox3.Visible = false;
            // 
            // textbox2
            // 
            textbox2.Location = new Point(313, 88);
            textbox2.Name = "textbox2";
            textbox2.ReadOnly = true;
            textbox2.Size = new Size(100, 23);
            textbox2.TabIndex = 0;
            textbox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 88);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // textbox1
            // 
            textbox1.Location = new Point(313, 37);
            textbox1.Name = "textbox1";
            textbox1.ReadOnly = true;
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 0;
            textbox1.Visible = false;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StatisticsForm";
            Text = "Statistics";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private TextBox textbox1;
        private Label label4;
        private Label label3;
        private TextBox textbox4;
        private TextBox textbox3;
        private TextBox textbox2;
        private Label label2;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox resulttextbox;
    }
}

