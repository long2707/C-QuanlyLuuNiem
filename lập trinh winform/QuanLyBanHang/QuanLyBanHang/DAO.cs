using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanHang
{
    class DAO
    {
        string s = "Data Source=DESKTOP-55T7ETC\\SQLEXPRESS;Initial Catalog=QuanlyBanHang;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        DataTable table;
        SqlDataAdapter adapter;

        public SqlConnection moKetnoi()
        {
            connection = new SqlConnection(s);
            if(connection.State== ConnectionState.Closed)
            {
                connection.Open();

            }
            return connection;
        }

        public SqlConnection dongKetnoi()
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
            return connection;
        }
        public DataTable xuly(string query)
        {
            moKetnoi();
            command = new SqlCommand(query, connection);
            table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
