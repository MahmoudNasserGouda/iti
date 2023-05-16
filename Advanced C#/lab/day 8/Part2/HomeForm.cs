using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            this.IsMdiContainer = true;
            InitializeComponent();

        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticleForm articleForm = new ArticleForm();
            articleForm.MdiParent = this;
            articleForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }
    }
}
