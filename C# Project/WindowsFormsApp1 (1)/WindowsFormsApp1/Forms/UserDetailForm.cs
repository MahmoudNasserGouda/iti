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
    public partial class UserDetailForm : Form
    {
        internal static int userID;
        public UserDetailForm()
        {
            InitializeComponent();
            grdBorrowed.AutoGenerateColumns = true;
            grdBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userID = UsersForm.userID;
            GetUserDetails();
        }

        private void GetUserDetails()
        {
            AppContext context;

            using (context = new AppContext())
            {
                User user = context.Users.Where(u => u.ID == userID).First();

                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtSSN.Text = user.SSN;
                txtPhone.Text = user.Phone;

                var books = (from b in context.UserBooks
                             where b.User.ID == userID
                             select new
                             {
                                 Id = b.Id,
                                 BookTitle = b.Book.Title,
                                 BookISBN = b.Book.ISBN,
                                 IsReturned = b.IsReturned.ToString(),
                                 Duration = b.Duration,
                                 BorrowedAt = b.BorrowedAt,
                             }).ToList();

                grdBorrowed.DataSource = books;
                grdBorrowed.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int Id = (int)senderGrid.Rows[e.RowIndex].Cells[1].Value;
                AppContext context = new AppContext();
                UserBook userBook = context.UserBooks.Where(u => u.User.ID == userID).Where(u => u.Id == Id).First();
                if (!userBook.IsReturned)
                {
                    userBook.IsReturned = true;

                    int BookId = (from ub in context.UserBooks
                                  where ub.Id == Id
                                  select ub.Book.ID).First();
                    Book book = context.Books.Where(b => b.ID == BookId).First();
                    book.AvailableCopies += 1;
                }


                context.SaveChanges();

                GetUserDetails();

            }
        }

    }
}
