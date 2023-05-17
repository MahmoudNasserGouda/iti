

using System.Data;
using System.Data.SqlClient;

namespace Part3
{
    public static class Program
    {
        public static int Main()
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


            while (rdr.Read() == true)
            {
                int ID = int.Parse(rdr["ID"].ToString());
                string Head = rdr["Head"].ToString();
                string Body = rdr["Body"].ToString();
                Console.WriteLine($"ID:{ID}, Head:{Head}");
                Console.WriteLine($"Body: {Body}");
                Console.WriteLine();
            }




            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
            return 0;
        }
    }
}