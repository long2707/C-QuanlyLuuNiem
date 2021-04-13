using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanLuuNiem.fromData
{
    class DAO
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=CuaHangLuuNiem;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        DataTable table;
        SqlDataAdapter adapter;

        public SqlConnection moKetnoi()
        {
            connection = new SqlConnection(s);
            if( connection.State== ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection DongKetnoi()
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }

        public DataTable xuLy(string query)
        {
            moKetnoi();
            command = new SqlCommand(query, connection);
            table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            DongKetnoi();
            return table;
        }
    }
}
