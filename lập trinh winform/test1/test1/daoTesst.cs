using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace test1
{
    class daoTesst
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=CuaHang;Integrated Security=True";
        SqlConnection connection;

        public  SqlConnection moKetnoi()
        {
            connection = new SqlConnection(s);
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection dongKetNoi()
        {
            connection = new SqlConnection(s);
            if(connection.State== ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
        public DataTable xuLy(string query)
        {
            moKetnoi();
            DataTable table = new DataTable();
           
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            dongKetNoi();
            return table;
        }
    }
}
