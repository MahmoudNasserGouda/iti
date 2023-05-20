namespace WinFormsApp1
{
    partial class UserDetailForm
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
            this.grdBorrowed = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBorrowed
            // 
            this.grdBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnReturn});
            this.grdBorrowed.Location = new System.Drawing.Point(12, 223);
            this.grdBorrowed.Name = "grdBorrowed";
            this.grdBorrowed.RowTemplate.Height = 25;
            this.grdBorrowed.Size = new System.Drawing.Size(776, 215);
            this.grdBorrowed.TabIndex = 0;
            this.grdBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBorrowed_CellContentClick);
            // 
            // btnReturn
            // 
            this.btnReturn.HeaderText = "";
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Text = "Return";
            this.btnReturn.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Detils";
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdBorrowed);
            this.Name = "UserDetailForm";
            this.Text = "UserDetail";
            ((System.ComponentModel.ISupportInitialize)(this.grdBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView grdBorrowed;

        #endregion

        private DataGridViewButtonColumn btnReturn;
        private Label label1;
    }
}