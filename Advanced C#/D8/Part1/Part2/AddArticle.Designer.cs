namespace Part2
{
    partial class AddArticleForm
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
            txtHead = new TextBox();
            txtBody = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnBrowse = new Button();
            btnAdd = new Button();
            lblAddError = new Label();
            dlgPhotos = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Head";
            // 
            // txtHead
            // 
            txtHead.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtHead.Location = new Point(139, 38);
            txtHead.Name = "txtHead";
            txtHead.Size = new Size(551, 31);
            txtHead.TabIndex = 1;
            // 
            // txtBody
            // 
            txtBody.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBody.Location = new Point(139, 94);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(551, 203);
            txtBody.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Body";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 331);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 4;
            label3.Text = "Photos";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(139, 320);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(99, 36);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(591, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_ClickAsync;
            // 
            // lblAddError
            // 
            lblAddError.AutoSize = true;
            lblAddError.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddError.ForeColor = Color.Red;
            lblAddError.Location = new Point(355, 390);
            lblAddError.Name = "lblAddError";
            lblAddError.Size = new Size(50, 20);
            lblAddError.TabIndex = 7;
            lblAddError.Text = "label4";
            lblAddError.Visible = false;
            // 
            // dlgPhotos
            // 
            dlgPhotos.FileName = "openFileDialog1";
            dlgPhotos.Multiselect = true;
            // 
            // AddArticleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAddError);
            Controls.Add(btnAdd);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(txtBody);
            Controls.Add(label2);
            Controls.Add(txtHead);
            Controls.Add(label1);
            Name = "AddArticleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Article";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHead;
        private TextBox txtBody;
        private Label label2;
        private Label label3;
        private Button btnBrowse;
        private Button btnAdd;
        private Label lblAddError;
        private OpenFileDialog dlgPhotos;
    }
}