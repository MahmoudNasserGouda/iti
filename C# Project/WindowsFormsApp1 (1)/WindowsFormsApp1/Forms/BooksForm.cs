using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class BooksForm : Form
    {
        internal static int bookID;
        public BooksForm()
        {
            InitializeComponent();
            grdBooks.AutoGenerateColumns = true;
            grdBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetCategories();
            GetBooks(0);
        }

        public void GetBooks(int index)
        {
            GetBooks(index, "");
        }

        public void GetBooks(int index, string search)
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                if (index == 0)
                {
                    var books = (from b in cn.Books
                                 where b.Title.StartsWith(search)
                                 select new
                                 {
                                     Id = b.ID,
                                     Author = b.Author,
                                     Title = b.Title,
                                     Description = b.Description,
                                     PathOfImage = b.PathOfImage,
                                     Category = b.Category.Name,
                                     TotalCopies = b.TotalCopies,
                                     AvailableCopies = b.AvailableCopies,
                                     ISBN = b.ISBN,
                                 }).ToList();
                    grdBooks.DataSource = books;
                    grdBooks.Refresh();
                }
                else
                {
                    var books = (from b in cn.Books
                                 where b.Category.Id == index
                                 where b.Title.StartsWith(search)
                                 select new
                                 {
                                     Id = b.ID,
                                     Author = b.Author,
                                     Title = b.Title,
                                     Description = b.Description,
                                     PathOfImage = b.PathOfImage,
                                     Category = b.Category.Name,
                                     TotalCopies = b.TotalCopies,
                                     AvailableCopies = b.AvailableCopies,
                                     ISBN = b.ISBN,
                                 }).ToList();
                    grdBooks.DataSource = books;
                    grdBooks.Refresh();
                }
            }
        }

        public void GetCategories()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var c = cn.Categories.ToList();
                Category all = new Category() { Id = 0, Name = "All" };
                c.Add(all);
                c.Sort((x, y) => x.Id.CompareTo(y.Id));
                categories.DisplayMember = "Name";
                categories.ValueMember = "Id";
                categories.DataSource = c;

            }
        }

        private void GrdBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bookindex = grdBooks.Rows[e.RowIndex].Index;
            bookID = (int)grdBooks.Rows[bookindex].Cells[0].Value;
            BookDetailForm f = new BookDetailForm();
            f.ButtonClicked += new EventHandler(AddBookForm_ButtonClicked);
            f.ShowDialog(this);
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm fn = new AddBookForm();
            fn.ButtonClicked += new EventHandler(AddBookForm_ButtonClicked);
            fn.ShowDialog(this);
        }

        private void AddBookForm_ButtonClicked(object sender, EventArgs e)
        {
            GetCategories();
            GetBooks(0);
        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (int)categories.SelectedValue;
            GetBooks(index);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            int index = (int)categories.SelectedValue;
            GetBooks(index, text);
        }

    }
}