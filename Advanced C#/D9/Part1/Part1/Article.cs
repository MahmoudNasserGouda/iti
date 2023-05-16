using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Part1
{
    public partial class ArticleFrom : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private SqlCommandBuilder builder;
        public ArticleFrom()
        {
            InitializeComponent();
            grdArticles.AutoGenerateColumns = true;
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MiniaDB"].ToString();
            cmd = new SqlCommand();
            cmd.Connection = con;
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            builder = new SqlCommandBuilder(adapter);
        }
        private void ArticleFrom_Load(object sender, EventArgs e)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "get_all_articles";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            grdArticles.DataSource = dt;
            grdArticles.Refresh();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(dt);
        }

        private void grdArticles_SelectionChanged(object sender, EventArgs e)
        {
            if (grdArticles.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdArticles.SelectedRows[0];
                int ArticleID = int.Parse(row.Cells[0].Value.ToString());


                ArticleDetailsForm details = new ArticleDetailsForm();
                details.ArticleID = ArticleID;
                details.Show();

            }

        }
    }
}