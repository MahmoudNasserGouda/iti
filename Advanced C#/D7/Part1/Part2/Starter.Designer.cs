namespace Part2
{
    partial class Starter
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            txtValue = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtValue.ForeColor = SystemColors.MenuHighlight;
            txtValue.Location = new Point(226, 100);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(250, 35);
            txtValue.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(228, 168);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(532, 103);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 2;
            button1.Text = "Move Value";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Starter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtValue);
            Name = "Starter";
            Text = "Starter Form";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtValue;
        private Label label1;
        private Button button1;
    }
}