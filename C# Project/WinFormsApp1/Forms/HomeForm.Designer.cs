namespace WinFormsApp1.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            menuStrip = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.WhiteSmoke;
            menuStrip.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, usersToolStripMenuItem, statisticsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.Transparent;
            booksToolStripMenuItem.Image = Properties.Resources.icon_book;
            booksToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(67, 20);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.BackColor = Color.Transparent;
            usersToolStripMenuItem.Image = Properties.Resources.kisspng_multi_user_end_user_users_group_information_5ae2558e385407_3783369715247824782307;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(63, 20);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.BackColor = Color.Transparent;
            statisticsToolStripMenuItem.Image = Properties.Resources.statistics_512;
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(81, 20);
            statisticsToolStripMenuItem.Text = "Statistics";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 426);
            panel1.TabIndex = 0;
            // 
            // HomeForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "HomeForm";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;

        #endregion

        private Panel panel1;
    }
}