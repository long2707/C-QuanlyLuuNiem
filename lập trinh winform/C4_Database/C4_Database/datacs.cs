using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace C4_Database
{
    class datacs
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=QLY_CuaHang;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter data;
        DataTable table;
       
        public SqlConnection moKetnoi()
        {
            connection = new SqlConnection(s);
            if(connection.State== System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection dongKetNoi()
        {
            connection = new SqlConnection(s);
            if(connection.State== System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
        public  truyVan(string query)
        {
            query = "SELECT*FROM dbo.account";
            command = new SqlCommand(query, connection);


        }

    }
}
