using System.Data;
using Microsoft.Data.SqlClient;
using AstroLazer.Library.Connection.Interface;

namespace AstroLazer.Library.Connection
{

    public class ConnectionBuilder : IConnectionBuilder 
    { 

        public ConnectionBuilder()
        {
          
        }
        public IDbConnection GetConnection
        {
            get
            {
                {
                    var connectionString = "Server=localhost;Database=Maui; User ID=sa;Password=admin;trustServerCertificate=true;encrypt = false;";
                    SqlConnection connection = new SqlConnection(connectionString);
                    return connection;
                }
            }
        }
    }
}
