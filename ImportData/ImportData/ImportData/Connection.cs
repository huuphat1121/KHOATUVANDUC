using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;
namespace ImportData
{
    public class Connection
    {
        static string conString = @"Server = localhost;Port=5432;UserId=postgres;Password=postgres;Database=ql_khoatu; CommandTimeout=100; Timeout=30;";
        //static string conString = @"Server = 192.168.145.4;Port=5432;UserId=pqm;Password=dbuser;Database=ynsdb; CommandTimeout=100; Timeout=30;";
        //string Connectionnnn = @"Server=.;AttachDbFilename=|DataDirectory|GIANGDAY.mdf; Database=KTLT;Trusted_Connection=Yes";
        //SqlConnection conn;
        //SqlCommand cmd = new SqlCommand();
        NpgsqlConnection conn = new NpgsqlConnection(conString);
        NpgsqlCommand cmd = new NpgsqlCommand();
        public Connection()
        {

            //conn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\GIANGDAY.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //conn = new SqlConnection(conString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Update(string strSQL)
        {
            cmd.Connection = conn;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
        }
        public Object GetValue(string sqlSQL)
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlSQL;
            //Thực thi truy vấn và trả về 1 giá trị cmd.ExecuteScalar()
            var value = cmd.ExecuteScalar();
            //Đóng kết nối
            return value;
        }
        public DataTable GetAllValue(string strSQL)
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            NpgsqlDataAdapter dapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dapter.Fill(dt);
            return dt;
        }

    }
}
