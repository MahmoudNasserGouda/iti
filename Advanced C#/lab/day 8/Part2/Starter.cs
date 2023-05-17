using System.Data.SqlClient;

namespace Part2
{
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtUserName.Text))
            {
                lblErrorMessage.Text = "You Must Provide UserName Or Password";
                lblErrorMessage.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.; Initial Catalog=Day8OfMinia; Integrated Security=True;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"SELECT count(*) from [User] Where UserName='{txtUserName.Text}' and Password = '{txtPassword.Text}'";

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                int value = int.Parse(cmd.ExecuteScalar().ToString());
                if (value == 0)
                {
                    lblErrorMessage.Text = "InValid UserName Or Password";
                    lblErrorMessage.Visible = true;
                }
                else
                {
                    HomeForm homeForm = new HomeForm();

                    Hide();
                    homeForm.Show();
                }
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();

            }
        }
    }
}