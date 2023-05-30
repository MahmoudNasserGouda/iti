namespace WinFormsApp1.Forms
{
    partial class DeleteBookForm
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
            nudCopies = new NumericUpDown();
            label1 = new Label();
            btnDelete = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCopies).BeginInit();
            SuspendLayout();
            // 
            // nudCopies
            // 
            nudCopies.Location = new Point(38, 52);
            nudCopies.Name = "nudCopies";
            nudCopies.Size = new Size(157, 23);
            nudCopies.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 23);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Copies to Delete:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(38, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(38, 144);
            label2.Name = "label2";
            label2.Size = new Size(38, 13);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // DeleteBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(240, 205);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(nudCopies);
            Name = "DeleteBookForm";
            Text = "Delete Book";
            ((System.ComponentModel.ISupportInitialize)nudCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCopies;
        private Label label1;
        private Button btnDelete;
        private Label label2;
    }
}