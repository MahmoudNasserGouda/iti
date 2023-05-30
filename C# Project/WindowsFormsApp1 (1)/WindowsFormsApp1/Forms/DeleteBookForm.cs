using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class DeleteBookForm : Form
    {
        internal static int bookID;
        public event EventHandler ButtonClicked;

        public DeleteBookForm()
        {
            InitializeComponent();
            bookID = BookDetailForm.bookID;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AppContext cn = new AppContext();
            Book book = cn.Books.Where(b => b.ID == bookID).First();
            int v = (int)nudCopies.Value;
            if (v < book.AvailableCopies)
            {
                book.TotalCopies -= v;
                book.AvailableCopies -= v;
                cn.SaveChanges();

                this.Close();

                if (ButtonClicked != null)
                    ButtonClicked(this, e);

            }
            else if (v == book.AvailableCopies)
            {
                book.TotalCopies -= v;
                book.AvailableCopies = 0;
                cn.SaveChanges();

                this.Close();

                if (ButtonClicked != null)
                    ButtonClicked(this, e);
            }
            else
            {
                label2.Visible = true;
                label2.Text = "not valid";
            }

        }
    }
}
