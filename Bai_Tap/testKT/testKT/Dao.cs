using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace testKT
{
    class Dao
    {
        string s = "Data Source=DESKTOP-55T7ETC\\SQLEXPRESS;Initial Catalog=QuanLySachTruyen;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        DataTable table;
        SqlDataAdapter adapter;
        public SqlConnection moKetNoi()
        {
            connection = new SqlConnection(s);
            if(connection.State== ConnectionState.Closed){
                connection.Open();
            }
            return connection;
        }
        public SqlConnection Dongketnoi()
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
            moKetNoi();
            command = new SqlCommand(query, connection);
            table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            Dongketnoi();
            return table;
        }
    }
}
