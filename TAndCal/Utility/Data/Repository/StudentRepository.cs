using AstroLazer.Library.Connection.Interface;
using TAndCal.Utility.Data.Repository.Interface;
using TAndCal.Model;
using Dapper;
using System.Data;

namespace TAndCal.Utility.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private IConnectionBuilder _connectionBuilder;
        public StudentRepository(IConnectionBuilder connectionBuilder) 
        { 
            _connectionBuilder = connectionBuilder; 
        }

        public bool Delete(int id)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
           
            con.Execute(@"update [Student] set
                                IsDeleted = 1
                          where Id = @Id", new {id});
            return true;
        }

        public List<StudentModel> Get()
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            return con.Query<StudentModel>(@"select * From  [Student] where IsDeleted = 0").ToList();
        }

        public StudentModel Get(int id)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            return con.Query<StudentModel>(@"select * From [Student] where IsDeleted = 0 AND Id = @id", new {id}).FirstOrDefault();
        }

        public int Insert(StudentModel uiPageTypeModel)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            var query = @"insert into [Student] (Name,Class,RollNo,Address) values(@Name,@Class,@RollNo,@Address)";
            con.Execute(query, uiPageTypeModel);
            return 0;
        }

        public bool Update(StudentModel uiPageTypeModel)
        {
            using IDbConnection con = _connectionBuilder.GetConnection;
            con.Execute(@"update [Student] Set  
                                Name = @Name,
                                Class = @Class,
                                RollNo = @RollNo,
                                Address = @Address
                          where Id = @Id", uiPageTypeModel);
            return true;
        }
    }
}
