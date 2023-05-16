using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class ArticleDetailsForm : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;
        public int ArticleID { get; set; }
        public ArticleDetailsForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniaDB"].ToString());
            cmd = new SqlCommand() { Connection = con, CommandType = CommandType.StoredProcedure };
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
        }
        private async Task GetArticleByID ()
        {
            await Task.Run(()=>
            {
                cmd.CommandText = "get_article_ByID";
                cmd.Parameters.AddWithValue("@id", ArticleID);
                adapter.Fill(ds);
            });
        }
        private async void ArticleDetailsForm_Load(object sender, EventArgs e)
        {
            await GetArticleByID();
            txtID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtHead.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBody.Text = ds.Tables[0].Rows[0][2].ToString();
            PictureBox last = null;
            PictureBox P =null; 
            foreach (DataRow item in ds.Tables[1].Rows)
            {
               if(last == null)
                {
                    Image img = Image.FromFile($"Photos\\{item[2].ToString()}");
                     P = new PictureBox();
                    P.Image = img;
                    pnlPhotos.Controls.Add(P);
                }
                else
                {

                    Image img = Image.FromFile($"Photos\\{item[2].ToString()}");
                     P = new PictureBox();
                    P.Location = new Point(last.Right + 10, last.Top);
                    P.Image = img;
                    pnlPhotos.Controls.Add(P);
                }
                last = P;

            }
        }
    }
}
