namespace WinFormsApp1
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            grdUser.AutoGenerateColumns = true;
            grdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}