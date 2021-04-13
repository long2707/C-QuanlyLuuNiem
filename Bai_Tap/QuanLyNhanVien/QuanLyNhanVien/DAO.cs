using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyNhanVien
{
    class DAO
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
        SqlConnection connection;
         
        SqlDataAdapter adapter;
        DataTable table;

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
            if(connection.State== ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
        public DataTable xuly(string query)
        {
            table = new DataTable();
            moKetnoi();
            
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            
            dongKetnoi();
            return table;
        }




        
    }
}
