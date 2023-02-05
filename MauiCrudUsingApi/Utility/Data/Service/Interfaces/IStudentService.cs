using TAndCal.Model;

namespace TAndCal.Utility.Data.Service.Interface
{
    public interface IStudentService
    {
		Task<int> Insert(StudentModel uiPageTypeModel);
        Task<List<StudentModel>> Get();
		Task<StudentModel> Get(int id);
		Task<bool> Update(StudentModel uiPageTypeModel);
        Task<bool> Delete(int id);
    }
}
