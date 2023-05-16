using ITI;

namespace TestMyControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labledClock1 = new ITI.LabledClock();
            labledClock1.Font = new Font("Arial", 50);
            labledClock1.Brush = Brushes.Blue;

            SuspendLayout();
            // 
            // labledClock1
            // 
            labledClock1.Label = "\r\n11:55:48 AM";
            labledClock1.Location = new Point(400, 225);
            labledClock1.Name = "labledClock1";
            labledClock1.Size = new Size(300, 75);
            labledClock1.TabIndex = 0;
            labledClock1.Text = "labledClock1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labledClock1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ITI.LabledClock labledClock1;
    }
}