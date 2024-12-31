using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CLsChat
{
    public static class MyAdo
    {
        public static int UserId { get; set; }
        private static readonly SqlConnection con = new SqlConnection();
        private static readonly SqlCommand cmd = new SqlCommand();

        public static void Begin()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con.Open();
            cmd.Connection = con;
        }

        public static int Execute(string query)
        {
            cmd.CommandText = query;
            return cmd.ExecuteNonQuery();
        }

        public static string Search(string query)
        {
            string res = null;
            cmd.CommandText = query;
            if (cmd.ExecuteScalar() != null)
                res = cmd.ExecuteScalar().ToString();
            return res;
        }

        public static DataTable GetDataTable(string query)
        {
            cmd.CommandText = query;
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            return dt;
        }
    }
}