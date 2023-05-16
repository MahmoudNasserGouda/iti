namespace Part1
{
    partial class ArticleDetailsForm
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
            label1 = new Label();
            txtID = new TextBox();
            txtHead = new TextBox();
            label2 = new Label();
            txtBody = new TextBox();
            label3 = new Label();
            pnlPhotos = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtID.Location = new Point(178, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(540, 34);
            txtID.TabIndex = 1;
            // 
            // txtHead
            // 
            txtHead.Enabled = false;
            txtHead.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtHead.Location = new Point(178, 75);
            txtHead.Name = "txtHead";
            txtHead.Size = new Size(540, 34);
            txtHead.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 2;
            label2.Text = "Head";
            // 
            // txtBody
            // 
            txtBody.Enabled = false;
            txtBody.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtBody.Location = new Point(178, 127);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(540, 130);
            txtBody.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 130);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Body";
            // 
            // pnlPhotos
            // 
            pnlPhotos.Location = new Point(57, 308);
            pnlPhotos.Name = "pnlPhotos";
            pnlPhotos.Size = new Size(661, 100);
            pnlPhotos.TabIndex = 6;
            // 
            // ArticleDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPhotos);
            Controls.Add(txtBody);
            Controls.Add(label3);
            Controls.Add(txtHead);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "ArticleDetailsForm";
            Text = "Article Details Form";
            Load += ArticleDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtHead;
        private Label label2;
        private TextBox txtBody;
        private Label label3;
        private Panel pnlPhotos;
    }
}