using System.Data;

namespace WebApiCrud.Library.Connection.Interface
{
    public interface IConnectionBuilder
    {

        IDbConnection GetConnection { get; }
    }
}
