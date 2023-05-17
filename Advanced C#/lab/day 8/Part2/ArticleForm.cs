using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class ArticleForm : Form
    {
        internal static int articleIndex;
        internal static DataTable Articles = new DataTable();

        public ArticleForm()
        {
            InitializeComponent();
            grdArticles.AutoGenerateColumns = true;
            grdArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetArticles();
        }


        public void GetArticles()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.; Initial Catalog=Day8OfMinia; Integrated Security=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * from Article";

            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            Articles = dt;
            if (dt.Rows.Count == 0) 
            {
                grdArticles.Visible = false;
                lblNotFound.Visible = true;
            }
            else
            {
                grdArticles.DataSource = dt;
                grdArticles.Refresh();
            }
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddArticleForm addArticleForm
                = new AddArticleForm();
            addArticleForm.ButtonClicked += new EventHandler(addArticleForm_ButtonClicked);
            addArticleForm.Show(this);
        }

        void addArticleForm_ButtonClicked(object sender, EventArgs e)
        {
            GetArticles();
        }

        private void grdArticles_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            articleIndex = (int) grdArticles.Rows[e.RowIndex].Index;
            BonusForm bonus = new BonusForm();
            bonus.Show(this);
        }
    }
}
