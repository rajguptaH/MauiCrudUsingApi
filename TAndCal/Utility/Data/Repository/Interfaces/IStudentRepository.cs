using TAndCal.Model;

namespace TAndCal.Utility.Data.Repository.Interface
{
    public interface IStudentRepository
    {
		Task<int> Insert(StudentModel uiPageTypeModel);
        Task<List<StudentModel>> Get();
		Task<StudentModel> Get(int id);
		Task<bool> Update(StudentModel uiPageTypeModel);
        Task<bool> Delete(int id);
    }
}
