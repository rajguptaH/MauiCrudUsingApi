using System.Data;

namespace AstroLazer.Library.Connection.Interface
{
    public interface IConnectionBuilder
    {

        IDbConnection GetConnection { get; }
    }
}
