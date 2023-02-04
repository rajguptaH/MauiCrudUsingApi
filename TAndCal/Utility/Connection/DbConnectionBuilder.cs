﻿using System.Data;
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
                  
                        var connectionString = "Server=localhost;Database=Maui; User ID=sa;Password=finefine123;trustServerCertificate=true;encrypt = false;";
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
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
