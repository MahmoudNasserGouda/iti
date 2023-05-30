using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm() { TopLevel = false };
            panel1.Controls.Clear();
            panel1.Controls.Add(booksForm);
            booksForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm() { TopLevel = false };
            panel1.Controls.Clear();
            panel1.Controls.Add(usersForm);
            usersForm.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm() { TopLevel = false };
            panel1.Controls.Clear();
            panel1.Controls.Add(statisticsForm);
            statisticsForm.Show();
        }
    }
}
