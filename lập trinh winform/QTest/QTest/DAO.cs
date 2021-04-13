using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QTest
{
    class DAO
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=test1;Integrated Security=True";
        SqlConnection connection;
    
        public  SqlConnection moKetnoi()
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
            if(connection.State== ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;

        }
        public DataTable xyly(string query)
        {
            moKetnoi();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(table);
            dongKetnoi();
            return table;
        }
    }
}
