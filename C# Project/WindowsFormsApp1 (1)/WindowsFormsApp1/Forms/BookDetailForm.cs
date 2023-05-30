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
    public partial class BookDetailForm : Form
    {
        internal static int bookID;
        public event EventHandler ButtonClicked;

        public BookDetailForm()
        {
            InitializeComponent();
            GetDetails();
        }


        private void GetDetails()
        {
            bookID = BooksForm.bookID;
            AppContext appContext = new AppContext();
            var book = (from b in appContext.Books
                        where b.ID == bookID
                        select new
                        {
                            Author = b.Author,
                            Title = b.Title,
                            Description = b.Description,
                            PathOfImage = b.PathOfImage,
                            Category = b.Category.Name,
                            TotalCopies = b.TotalCopies,
                            AvailableCopies = b.AvailableCopies,
                            ISBN = b.ISBN,
                        }).First();
            BDAuthor.Text = book.Author;
            BDTitle.Text = book.Title;
            BDDescription.Text = book.Description;
            BDGategory.Text = book.Category;
            BDtotalcopies.Text = book.TotalCopies.ToString();
            BDAvailable.Text = book.AvailableCopies.ToString();
            BDISBAN.Text = book.ISBN;
            cover.ImageLocation = "Photos\\" + book.PathOfImage;

            if (book.AvailableCopies == 0)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void EditBookForm_ButtonClicked(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditBookForm fe = new EditBookForm();
            fe.ButtonClicked += new EventHandler(EditBookForm_ButtonClicked);
            fe.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteBookForm fe = new DeleteBookForm();
            fe.ButtonClicked += new EventHandler(EditBookForm_ButtonClicked);
            fe.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowingBookForm fe = new BorrowingBookForm();
            fe.ButtonClicked += new EventHandler(EditBookForm_ButtonClicked);
            fe.ShowDialog(this);
        }

        private void BookDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
    }
}
