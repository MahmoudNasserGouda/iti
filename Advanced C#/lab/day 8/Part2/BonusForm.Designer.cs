namespace Part2
{
    partial class BonusForm
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(36, 45);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(35, 15);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Head";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(36, 91);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 15);
            this.lblBody.TabIndex = 1;
            this.lblBody.Text = "Body";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(246, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // BonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHead);
            this.Name = "BonusForm";
            this.Text = "BonusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHead;
        private Label lblBody;
        private Label lblDate;
    }
}