using WebApiCrud.Models;

namespace WebApiCrud.Utility.Data.Service.Interface
{
    public interface IStudentService
    {
        int Insert(StudentModel uiPageTypeModel);
        List<StudentModel> Get();
        StudentModel Get(int id);
        bool Update(StudentModel uiPageTypeModel);
        bool Delete(int id);
    }
}
