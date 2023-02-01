# Crud Operation In Maui Blazor Using Dapper
## You can sync with server with this Dapper framework

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://instagram.com/bug__developer)


This is a Multi platform Application, mobile-ready, Windows Ready,Mac os Ready,
and Ios Ready.

- This is Helpful For Learning How to Do Crud Operation In Maui Blazor Using Dapper
- Give A Like To This Repo If you Found Something Helpful
- ✨RNG✨
## Requirments
- Visual Studio 2019 or latest
- SQL Server Management Studio (SSMS) 
- .net 6.0 or newest 

## Setup 
- Clone The Repository And Then Open This .sln Proj File 
- Publish The Db Proj In Your Ssms
- Change Your Database Configurations In Utility/Connection/ConnectionBuilder.cs 
```csharp
 public IDbConnection GetConnection
       {
         get
          {
            {
              var connectionString = "Server=yourserverName;Database=Dbname ID=sa;Password=password;trustServerCertificate=true;encrypt = false;";
              SqlConnection connection = new SqlConnection(connectionString);
              return connection;
            }
          }
       }
```
- Thats it
## Thanks 

- I would Like To collaborate With Other Developers💛
- Mail : Rajkumar00999.rk@gmail.com
-  [Follow Us On Instagram]( https://instagram.com/raj__rr)
- [![GitHub rajguptaH](https://img.shields.io/github/followers/rajguptaH?label=follow&style=social)](https://github.com/rajguptaH)

## License

MIT

**Free Software, Hell Yeah!**
-
![visitors](https://visitor-badge.glitch.me/badge?page_id=rajguptaH.MauiCrudUsingDapper)
## Mail Me Or Give a messege In Instagram If You Have Any Suggestion / Questions / Issues or Feel Free To Contribute
