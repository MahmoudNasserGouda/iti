namespace WinFormsApp1.Forms
{
    partial class BookDetailForm
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            cover = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label15 = new Label();
            BDTitle = new TextBox();
            BDAuthor = new TextBox();
            BDDescription = new TextBox();
            BDGategory = new TextBox();
            BDISBAN = new TextBox();
            BDtotalcopies = new TextBox();
            BDAvailable = new TextBox();
            ((System.ComponentModel.ISupportInitialize)cover).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(24, 287);
            button1.Name = "button1";
            button1.Size = new Size(136, 60);
            button1.TabIndex = 1;
            button1.Text = "borrow book ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(179, 287);
            button2.Name = "button2";
            button2.Size = new Size(149, 60);
            button2.TabIndex = 2;
            button2.Text = "edit book ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(348, 287);
            button3.Name = "button3";
            button3.Size = new Size(138, 60);
            button3.TabIndex = 3;
            button3.Text = "remove book ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Author :";
            // 
            // cover
            // 
            cover.Location = new Point(12, 12);
            cover.Name = "cover";
            cover.Size = new Size(172, 234);
            cover.SizeMode = PictureBoxSizeMode.StretchImage;
            cover.TabIndex = 6;
            cover.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 12);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 86);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 0;
            label5.Text = "Description :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 125);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 0;
            label9.Text = "Gategory :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(204, 231);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 0;
            label11.Text = "Available Copies :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(204, 196);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 0;
            label12.Text = "Total of Copies :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(204, 161);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 0;
            label15.Text = "ISBN :";
            // 
            // BDTitle
            // 
            BDTitle.Location = new Point(319, 12);
            BDTitle.Name = "BDTitle";
            BDTitle.ReadOnly = true;
            BDTitle.Size = new Size(176, 23);
            BDTitle.TabIndex = 0;
            // 
            // BDAuthor
            // 
            BDAuthor.Location = new Point(319, 47);
            BDAuthor.Name = "BDAuthor";
            BDAuthor.ReadOnly = true;
            BDAuthor.Size = new Size(176, 23);
            BDAuthor.TabIndex = 0;
            // 
            // BDDescription
            // 
            BDDescription.Location = new Point(319, 86);
            BDDescription.Name = "BDDescription";
            BDDescription.ReadOnly = true;
            BDDescription.Size = new Size(176, 23);
            BDDescription.TabIndex = 0;
            // 
            // BDGategory
            // 
            BDGategory.Location = new Point(319, 125);
            BDGategory.Name = "BDGategory";
            BDGategory.ReadOnly = true;
            BDGategory.Size = new Size(176, 23);
            BDGategory.TabIndex = 0;
            // 
            // BDISBAN
            // 
            BDISBAN.Location = new Point(319, 161);
            BDISBAN.Name = "BDISBAN";
            BDISBAN.ReadOnly = true;
            BDISBAN.Size = new Size(176, 23);
            BDISBAN.TabIndex = 0;
            // 
            // BDtotalcopies
            // 
            BDtotalcopies.Location = new Point(319, 196);
            BDtotalcopies.Name = "BDtotalcopies";
            BDtotalcopies.ReadOnly = true;
            BDtotalcopies.Size = new Size(176, 23);
            BDtotalcopies.TabIndex = 0;
            // 
            // BDAvailable
            // 
            BDAvailable.Location = new Point(319, 231);
            BDAvailable.Name = "BDAvailable";
            BDAvailable.ReadOnly = true;
            BDAvailable.Size = new Size(176, 23);
            BDAvailable.TabIndex = 0;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(542, 386);
            Controls.Add(BDAvailable);
            Controls.Add(BDtotalcopies);
            Controls.Add(BDISBAN);
            Controls.Add(BDGategory);
            Controls.Add(BDDescription);
            Controls.Add(BDAuthor);
            Controls.Add(BDTitle);
            Controls.Add(cover);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BookDetailForm";
            Text = "BookDetails";
            FormClosed += BookDetailForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)cover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private PictureBox cover;
        private Label label3;
        private Label label5;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label15;
        private TextBox BDTitle;
        private TextBox BDAuthor;
        private TextBox BDDescription;
        private TextBox BDGategory;
        private TextBox BDISBAN;
        private TextBox BDtotalcopies;
        private TextBox BDAvailable;
    }
}