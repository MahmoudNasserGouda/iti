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
    public partial class BorrowingBookForm : Form
    {
        internal static int bookID;
        public event EventHandler ButtonClicked;

        public BorrowingBookForm()
        {
            InitializeComponent();
            bookID = BookDetailForm.bookID;
            GetUsers();
        }

        private void GetUsers()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var u = cn.Users.ToList();
                u.Sort((x, y) => x.ID.CompareTo(y.ID));
                cbUser.DisplayMember = "Name";
                cbUser.ValueMember = "ID";
                cbUser.DataSource = u;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            AppContext context = new AppContext();

            Book book = context.Books.Where(b => b.ID == bookID).First();

            User user = context.Users.Where(u => u.ID == (int)cbUser.SelectedValue).First();

            book.AvailableCopies -= 1;

            UserBook userBook = new UserBook()
            {
                User = user,
                Book = book,
                Duration = (int)nudPeriod.Value,
                BorrowedAt = DateTime.Now,
                IsReturned = false
            };

            context.UserBooks.Add(userBook);

            context.SaveChanges();

            this.Close();

            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
    }
}
