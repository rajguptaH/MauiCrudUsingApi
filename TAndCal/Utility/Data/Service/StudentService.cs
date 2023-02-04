using TAndCal.Utility.Data.Service.Interface;
using TAndCal.Model;
using Newtonsoft.Json;
using System.Text;

namespace TAndCal.Utility.Data.Service
{
	public class StudentService : IStudentService
    {
		
        private string _baseUrl = "http://192.168.1.5:5050";
        public StudentService() 
        { 
        }
        public async Task< bool> Delete(int id)
        {
			try
			{
				using (var client = new HttpClient())
				{
					string url = $"{_baseUrl}/api/Student/Delete/{id}";
                    var apiResponse = await client.DeleteAsync(url);

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				string msg = ex.Message;
			}
			return false;
		}

        public async Task<List<StudentModel>> Get()
        {
            var returnResponse = new List<StudentModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}/api/student";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<List<StudentModel>>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;

        }

        public async Task<StudentModel> Get(int studentID)
        {
			try
			{
				using (var client = new HttpClient())
				{
					string url = $"{_baseUrl}/api/Student/GetStudentByID/{studentID}";
					var apiResponse = await client.GetAsync(url);

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var response = await apiResponse.Content.ReadAsStringAsync();
						var deserilizeResponse = JsonConvert.DeserializeObject<StudentModel>(response);

                        return deserilizeResponse;
					}
				}
			}
			catch (Exception ex)
			{
				string msg = ex.Message;
			}
			return null;

		}

		public async Task<int> Insert(StudentModel uiPageTypeModel)
        {
         
            
			try
			{
				using (var client = new HttpClient())
				{
					string url = $"{_baseUrl}/api/Student/AddStudent";

					var serializeContent = JsonConvert.SerializeObject(uiPageTypeModel);

					var apiResponse = await client.PostAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
                        return 1;
					}
				}
			}
			catch (Exception ex)
			{
				string msg = ex.Message;
                return 0;
			}
			return 0;
        }

        public async Task<bool> Update(StudentModel uiPageTypeModel)
        {
			try
			{
				using (var client = new HttpClient())
				{
					string url = $"{_baseUrl}/api/Student/UpdateStudent";

					var serializeContent = JsonConvert.SerializeObject(uiPageTypeModel);

					var apiResponse = await client.PutAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				string msg = ex.Message;
			}
			return false;
		}
    }
}
