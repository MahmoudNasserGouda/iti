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
    public partial class AddArticleForm : Form
    {
        public event EventHandler ButtonClicked;
        private List<string> Files = new List<string>();
        public AddArticleForm()
        {
            InitializeComponent();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result
                = dlgPhotos.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (dlgPhotos.FileNames.Count() > 0)
                {
                    foreach (string file in dlgPhotos.FileNames)
                    {

                        string NewName = Path.GetFileName(file);
                        string New = Guid.NewGuid().ToString() + NewName;
                        File.Copy(file, $"Photos\\{New}");
                        Files.Add(New);
                    }
                }
            }
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtHead.Text) ||
                string.IsNullOrEmpty(txtBody.Text) ||
                dlgPhotos.FileNames.Count() == 0
                )
            {
                lblAddError.Text
                    = "All Fields Are Required";
                lblAddError.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.; Initial Catalog=Day8OfMinia; Integrated Security=True;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = $"add_article";
                cmd.Parameters.AddWithValue("@head", txtHead.Text);
                cmd.Parameters.AddWithValue("@body", txtBody.Text);
                string files = "";
                for (int i =0; i< Files.Count; i++)
                {
                    if(i == Files.Count - 1)
                    {
                        files += Files[i];
                    }
                    else
                    {
                        files += Files[i] + ",";
                    }
                  
                }
                cmd.Parameters.AddWithValue("@files", files);
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
               int DONE = await cmd.ExecuteNonQueryAsync();
                if(DONE != 0)
                {
                    //MessageBox.Show("Added Successfully");
                    this.Close();
                    if (ButtonClicked != null)
                        ButtonClicked(this, e);
                }
                else
                {
                    lblAddError.Text = "Try Again Later";
                    lblAddError.Visible = true;
                }
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
