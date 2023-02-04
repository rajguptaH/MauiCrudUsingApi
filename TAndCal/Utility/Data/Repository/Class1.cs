//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WebAPIIntegreationInBlazorApp.Models;

//namespace WebAPIIntegreationInBlazorApp.Services
//{
//    public class StudentService : IStudentService
//    {
//        private string _baseUrl = "http://192.168.0.185";

//        public async Task<MainResponseModel> AddStudent(AddUpdateStudentRequest studentRequest)
//        {
//            var returnResponse = new MainResponseModel();
//            try
//            {
//                using (var client = new HttpClient())
//                {
//                    string url = $"{_baseUrl}/api/Students/AddStudent";

//                    var serializeContent = JsonConvert.SerializeObject(studentRequest);

//                    var apiResponse = await client.PostAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));

//                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
//                    {
//                        var response = await apiResponse.Content.ReadAsStringAsync();
//                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                string msg = ex.Message;
//            }
//            return returnResponse;
//        }



//        public async Task<List<StudentResponseModel>> GetAllStudentList()
//        {
//            var returnResponse = new List<StudentResponseModel>();
//            try
//            {
//                using (var client = new HttpClient())
//                {
//                    string url = $"{_baseUrl}/api/Students/GetAllStudent";
//                    var apiResponse = await client.GetAsync(url);

//                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
//                    {
//                        var response = await apiResponse.Content.ReadAsStringAsync();
//                        var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

//                        if (deserilizeResponse.IsSuccess)
//                        {
//                            returnResponse = JsonConvert.DeserializeObject<List<StudentResponseModel>>(deserilizeResponse.Content.ToString());
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                string msg = ex.Message;
//            }
//            return returnResponse;

//        }

//        public async Task<StudentResponseModel> GetStudentDetailByStudentID(int studentID)
//        {
//            var returnResponse = new StudentResponseModel();
//            try
//            {
//                using (var client = new HttpClient())
//                {
//                    string url = $"{_baseUrl}/api/Students/GetStudentByStudentID/{studentID}";
//                    var apiResponse = await client.GetAsync(url);

//                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
//                    {
//                        var response = await apiResponse.Content.ReadAsStringAsync();
//                        var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

//                        if (deserilizeResponse.IsSuccess)
//                        {
//                            returnResponse = JsonConvert.DeserializeObject<StudentResponseModel>(deserilizeResponse.Content.ToString());
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                string msg = ex.Message;
//            }
//            return returnResponse;

//        }

//        public async Task<MainResponseModel> DeleteStudent(AddUpdateStudentRequest studentRequest)
//        {
//            var returnResponse = new MainResponseModel();
//            try
//            {
//                using (var client = new HttpClient())
//                {
//                    string url = $"{_baseUrl}/api/Students/DeleteStudent";

//                    var serializeContent = JsonConvert.SerializeObject(studentRequest);

//                    var request = new HttpRequestMessage();
//                    request.Method = HttpMethod.Delete;
//                    request.RequestUri = new Uri(url);
//                    request.Content = new StringContent(serializeContent, Encoding.UTF8, "application/json");
//                    var apiResponse = await client.SendAsync(request);

//                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
//                    {
//                        var response = await apiResponse.Content.ReadAsStringAsync();
//                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                string msg = ex.Message;
//            }
//            return returnResponse;
//        }
//        public async Task<MainResponseModel> UpdateStudent(AddUpdateStudentRequest studentRequest)
//        {
//            var returnResponse = new MainResponseModel();
//            try
//            {
//                using (var client = new HttpClient())
//                {
//                    string url = $"{_baseUrl}/api/Students/UpdateStudent";

//                    var serializeContent = JsonConvert.SerializeObject(studentRequest);

//                    var apiResponse = await client.PutAsync(url, new StringContent(serializeContent, Encoding.UTF8, "application/json"));

//                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
//                    {
//                        var response = await apiResponse.Content.ReadAsStringAsync();
//                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                string msg = ex.Message;
//            }
//            return returnResponse;
//        }
//    }
//}