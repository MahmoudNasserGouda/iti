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
    public partial class BonusForm : Form
    {
        public BonusForm()
        {
            InitializeComponent();
            GetArticle();
        }

        public void GetArticle()
        {
            int articleID = (int) ArticleForm.Articles.Rows[ArticleForm.articleIndex][0];
            lblHead.Text = ArticleForm.Articles.Rows[ArticleForm.articleIndex][1].ToString();
            lblBody.Text = ArticleForm.Articles.Rows[ArticleForm.articleIndex][2].ToString();
            lblDate.Text = ArticleForm.Articles.Rows[ArticleForm.articleIndex][3].ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.; Initial Catalog=Day8OfMinia; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * from ArticlePhoto where ArticleID = {articleID}";

            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);

            int pos = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Controls.Add(new PictureBox
                {
                    Size = new System.Drawing.Size(230,230),
                    Location = new System.Drawing.Point(40 + pos, 140),
                    ImageLocation = "Photos\\" + dr.ItemArray[2],
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
                pos += 250;
            }
            

            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }
    }
}
