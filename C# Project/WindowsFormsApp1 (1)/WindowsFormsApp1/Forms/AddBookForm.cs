using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class AddBookForm : Form
    {
        public event EventHandler ButtonClicked;
        private string FileName;

        public AddBookForm()
        {
            InitializeComponent();
            BKGetCategories();
            FileName = "Not Found";
        }

        private void BtnSaveAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BKname.Text) ||
                string.IsNullOrEmpty(BKAuthor.Text) ||
                string.IsNullOrEmpty(BKISBN.Text) ||
                string.IsNullOrEmpty(BKNOS.Text) ||
                string.IsNullOrEmpty(BKDes.Text) ||
                string.IsNullOrEmpty(BKCategory.SelectedValue.ToString()) ||
                ofd.FileNames.Count() == 0)
            {
                lblAddError.Text
                    = "All Fields Are Required";
                lblAddError.Visible = true;
            }
            else
            {
                try
                {
                    AppContext context = new AppContext();

                    string BookName = BKname.Text;
                    string BookPublisher = BKAuthor.Text;
                    string ISBN = BKISBN.Text;
                    int number = int.Parse(BKNOS.Text);
                    string des = BKDes.Text;
                    string path = btnBrowse.Text;
                    int categoryIndex = (int)BKCategory.SelectedValue;
                    Category category = context.Categories.Find(categoryIndex);
                    
                    var bookFromDB = (from s in context.Books
                                      where s.ISBN == ISBN ||
                                      s.Title == BookName
                                      select s).ToList();
                    if (bookFromDB.Any())
                    {
                        lblAddError.Text = "Book already exists";
                        lblAddError.Visible = true;
                    }

                    Book BK = new Book()
                    {
                        Title = BookName,
                        TotalCopies = number,
                        AvailableCopies = number,
                        ISBN = ISBN,
                        Author = BookPublisher,
                        Category = category,
                        Description = des,
                        PathOfImage = FileName,
                    };

                    context.Books.Add(BK);
                    context.SaveChanges();

                    this.Close();
                    if (ButtonClicked != null)
                        ButtonClicked(this, e);
                }
                catch (DbEntityValidationException ex)
                {
                    lblAddError.Text = ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                    lblAddError.Visible = true;
                }
                catch (Exception ex)
                {
                    lblAddError.Text = ex.Message;
                    lblAddError.Visible = true;
                }
            }
        }


        public void BKGetCategories()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var c = cn.Categories.ToList();

                c.Sort((x, y) => x.Id.CompareTo(y.Id));
                BKCategory.DisplayMember = "Name";
                BKCategory.ValueMember = "Id";
                BKCategory.DataSource = c;

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
