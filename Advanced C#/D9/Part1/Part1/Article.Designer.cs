namespace Part1
{
    partial class ArticleFrom
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
            grdArticles = new DataGridView();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)grdArticles).BeginInit();
            SuspendLayout();
            // 
            // grdArticles
            // 
            grdArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdArticles.Location = new Point(12, 117);
            grdArticles.Name = "grdArticles";
            grdArticles.RowTemplate.Height = 25;
            grdArticles.Size = new Size(767, 150);
            grdArticles.TabIndex = 0;
            grdArticles.SelectionChanged += grdArticles_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 49);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ArticleFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 486);
            Controls.Add(btnUpdate);
            Controls.Add(grdArticles);
            Name = "ArticleFrom";
            Text = "Articles";
            Load += ArticleFrom_Load;
            ((System.ComponentModel.ISupportInitialize)grdArticles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdArticles;
        private Button btnUpdate;
    }
}