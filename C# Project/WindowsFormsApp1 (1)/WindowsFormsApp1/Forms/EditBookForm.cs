using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class EditBookForm : Form
    {
        internal static int bookID;
        private string FileName;
        public event EventHandler ButtonClicked;

        public EditBookForm()
        {
            InitializeComponent();
            bookID = BookDetailForm.bookID;
            FillData();
            GetCategories();
        }

        private void GetCategories()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var c = cn.Categories.ToList();
                c.Sort((x, y) => x.Id.CompareTo(y.Id));
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
                cbCategory.DataSource = c;
            }
        }

        private void FillData()
        {
            AppContext context = new AppContext();
            Book book = context.Books.Where(b => b.ID == bookID).First();

            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtDescription.Text = book.Description;
            nudTotalCopies.Value = book.TotalCopies;
            nudTotalCopies.Minimum = book.TotalCopies;
            FileName = book.PathOfImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == null || txtAuthor.Text == null
                 || txtDescription.Text == null || cbCategory.SelectedValue == null)
            {
                lblError.Text = "Enter Values";
                lblError.Visible = true;
            }
            else
            {
                AppContext cn = new AppContext();
                Book book = cn.Books.Where(b => b.ID == bookID).First();

                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Description = txtDescription.Text;
                book.PathOfImage = FileName == null ? book.PathOfImage : FileName;
                book.AvailableCopies += (int)(nudTotalCopies.Value - book.TotalCopies);
                book.TotalCopies = (int)nudTotalCopies.Value;
                Category category = cn.Categories.Where(c => c.Id == (int)cbCategory.SelectedValue).First();
                book.Category = category;

                cn.SaveChanges();
                this.Close();
                if (ButtonClicked != null)
                    ButtonClicked(this, e);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result
                = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string Name = Path.GetFileName(ofd.FileName);
                string NewName = Guid.NewGuid().ToString() + Name;
                File.Copy(ofd.FileName, $"Photos\\{NewName}");
                FileName = NewName;
            }
        }
    }
}
