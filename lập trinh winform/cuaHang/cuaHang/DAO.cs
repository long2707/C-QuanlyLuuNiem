using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace cuaHang
{
    class DAO
    {
        string s = "Data Source=.\\sqlexpress;Initial Catalog=CuaHang;Integrated Security=True";
        SqlConnection connection;

        DataTable dtTable;
        SqlDataAdapter dataAdp;

        public SqlConnection moKetNoi()
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection dongKetNoi()
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


            dtTable = new DataTable();
            moKetNoi();
            dataAdp = new SqlDataAdapter(query, connection);
            dataAdp.Fill(dtTable);
            dongKetNoi();

            return dtTable;
        }
    }
}
