namespace Part2
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            label1.Text = txtValue.Text;
            txtValue.Text = "";
        }
    }
}