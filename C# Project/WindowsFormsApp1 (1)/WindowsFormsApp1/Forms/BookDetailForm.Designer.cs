using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cover = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BDTitle = new System.Windows.Forms.TextBox();
            this.BDAuthor = new System.Windows.Forms.TextBox();
            this.BDDescription = new System.Windows.Forms.TextBox();
            this.BDGategory = new System.Windows.Forms.TextBox();
            this.BDISBAN = new System.Windows.Forms.TextBox();
            this.BDtotalcopies = new System.Windows.Forms.TextBox();
            this.BDAvailable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(21, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "borrow book ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(153, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "edit book ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += button2_Click;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(298, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "remove book ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += button3_Click;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author :";
            // 
            // cover
            // 
            this.cover.Location = new System.Drawing.Point(10, 10);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(147, 203);
            this.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover.TabIndex = 6;
            this.cover.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gategory :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Available Copies :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total of Copies :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ISBN :";
            // 
            // BDTitle
            // 
            this.BDTitle.Location = new System.Drawing.Point(273, 10);
            this.BDTitle.Name = "BDTitle";
            this.BDTitle.ReadOnly = true;
            this.BDTitle.Size = new System.Drawing.Size(151, 20);
            this.BDTitle.TabIndex = 0;
            // 
            // BDAuthor
            // 
            this.BDAuthor.Location = new System.Drawing.Point(273, 41);
            this.BDAuthor.Name = "BDAuthor";
            this.BDAuthor.ReadOnly = true;
            this.BDAuthor.Size = new System.Drawing.Size(151, 20);
            this.BDAuthor.TabIndex = 0;
            // 
            // BDDescription
            // 
            this.BDDescription.Location = new System.Drawing.Point(273, 75);
            this.BDDescription.Name = "BDDescription";
            this.BDDescription.ReadOnly = true;
            this.BDDescription.Size = new System.Drawing.Size(151, 20);
            this.BDDescription.TabIndex = 0;
            // 
            // BDGategory
            // 
            this.BDGategory.Location = new System.Drawing.Point(273, 108);
            this.BDGategory.Name = "BDGategory";
            this.BDGategory.ReadOnly = true;
            this.BDGategory.Size = new System.Drawing.Size(151, 20);
            this.BDGategory.TabIndex = 0;
            // 
            // BDISBAN
            // 
            this.BDISBAN.Location = new System.Drawing.Point(273, 140);
            this.BDISBAN.Name = "BDISBAN";
            this.BDISBAN.ReadOnly = true;
            this.BDISBAN.Size = new System.Drawing.Size(151, 20);
            this.BDISBAN.TabIndex = 0;
            // 
            // BDtotalcopies
            // 
            this.BDtotalcopies.Location = new System.Drawing.Point(273, 170);
            this.BDtotalcopies.Name = "BDtotalcopies";
            this.BDtotalcopies.ReadOnly = true;
            this.BDtotalcopies.Size = new System.Drawing.Size(151, 20);
            this.BDtotalcopies.TabIndex = 0;
            // 
            // BDAvailable
            // 
            this.BDAvailable.Location = new System.Drawing.Point(273, 200);
            this.BDAvailable.Name = "BDAvailable";
            this.BDAvailable.ReadOnly = true;
            this.BDAvailable.Size = new System.Drawing.Size(151, 20);
            this.BDAvailable.TabIndex = 0;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 335);
            this.Controls.Add(this.BDAvailable);
            this.Controls.Add(this.BDtotalcopies);
            this.Controls.Add(this.BDISBAN);
            this.Controls.Add(this.BDGategory);
            this.Controls.Add(this.BDDescription);
            this.Controls.Add(this.BDAuthor);
            this.Controls.Add(this.BDTitle);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BookDetailForm";
            this.Text = "BookDetails";
            this.FormClosed += BookDetailForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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