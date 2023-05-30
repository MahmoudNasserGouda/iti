using System;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using WinFormsApp1.Models;
using System.Linq;

namespace WinFormsApp1
{
    public partial class UsersForm : Form
    {
        internal static int userID;
        public UsersForm()
        {
            InitializeComponent();
            grdUser.AutoGenerateColumns = true;
            grdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetUsers();
        }

        public void GetUsers()
        {
            AppContext context;
            using (context = new AppContext())
            {
                var users = (from u in context.Users
                             select new
                             {
                                 Id = u.ID,
                                 Name = u.Name,
                                 Email = u.Email,
                                 SSN = u.SSN,
                                 Phone = u.Phone
                             }).ToList();

                grdUser.DataSource = users;
                grdUser.Refresh();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AppContext cn = new AppContext();
            string text = txtSearch.Text;
            var usersfromtextsearch = (from s in cn.Users
                                       where s.Name.StartsWith(text) || s.SSN.StartsWith(text)
                                       select s).ToList();
            grdUser.DataSource = usersfromtextsearch;
            grdUser.Refresh();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            adduserForm news = new adduserForm();
            news.ButtonClicked += new EventHandler(AddBookForm_ButtonClicked);
            news.ShowDialog(this);
        }

        private void AddBookForm_ButtonClicked(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void GrdUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int index = senderGrid.Rows[e.RowIndex].Index;
            userID = (int)senderGrid.Rows[index].Cells[0].Value;
            UserDetailForm UDF = new UserDetailForm();
            UDF.ShowDialog(this);
        }
    }
}