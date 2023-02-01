using TAndCal.Model;

namespace TAndCal.Utility.Data.Repository.Interface
{
    public interface IStudentRepository
    {
        int Insert(StudentModel uiPageTypeModel);
        List<StudentModel> Get();
        StudentModel Get(int id);
        bool Update(StudentModel uiPageTypeModel);
        bool Delete(int id);
    }
}
