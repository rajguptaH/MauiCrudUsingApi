using System.Data;
using System.Data.SqlClient;
using WebApiCrud.Library.Connection.Interface;

namespace WebApiCrud.Library.Connection
{

    public class ConnectionBuilder : IConnectionBuilder 
    {
        private readonly IConfiguration _configuration;
        public ConnectionBuilder(IConfiguration configuration)
        {
          _configuration = configuration;
        }
        public IDbConnection GetConnection
        {
            get
            {
                {
                  
                      // var connectionString = "Server=localhost;Database=Maui; User ID=sa;Password=admin;";
                    try
                    {
                        
                        SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:Prop"]);
                        return connection;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    
                    
                    
                }
            }
        }
    }
}
