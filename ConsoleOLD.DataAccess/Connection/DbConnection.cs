using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLD.Connection
{
    public class DbConnection
    {
        public static SqlConnection getConnection()
        {
            string MyConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConsoleDatabaseShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(MyConnection);
            return connection;
        }
    }
}
