using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_05
{
    public static class DB
    {
        private static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PC_05;Integrated Security=True;";
        private static SqlConnection con;
        private static bool IsOpen;

        public static void Open()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                IsOpen = true;
            }
            catch(Exception e)
            {
                IsOpen = false;
                return;
            }
        }

        public static DataSet Login(string username, string password)
        {
            if (!IsOpen)
                Open();

            string hashedPassword = SHA256Hash(password);

            //MessageBox.Show(hashedPassword);
            string sql = $"SELECT * FROM Employee WHERE Username='{username}' AND Password='{hashedPassword}'";

            DataSet ds = new DataSet() ;
            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(sql, con));
            da.Fill(ds);

            return ds;
        }

        public static DataSet GetDataset(string sql)
        {
            if (!IsOpen)
                Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(sql, con));
            da.Fill(ds);
            return ds;
        }

        public static void ExecNonQuery(string sql)
        {
            if (!IsOpen)
                Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public static string SHA256Hash(string text)
        {
            string hashedPassword = default(string);


            using (HashAlgorithm hash = new SHA256Managed())
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                var result = hash.ComputeHash(bytes);
                hashedPassword = string.Join(string.Empty, result.Select(x => x.ToString("x2")));
            }

            return hashedPassword;
        }
    }
}
