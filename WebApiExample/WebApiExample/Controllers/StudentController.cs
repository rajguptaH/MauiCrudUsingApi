using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCrud.Models;
using WebApiCrud.Utility.Data.Service.Interface;

namespace WebApiCrud.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IStudentService _studentService;

        public StudentController(ILogger<StudentController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet(Name = "GetStudent")]
        public IEnumerable<StudentModel> Get()
        {
            return _studentService.Get();
        }
        [HttpGet("GetStudentById/{StudentID}")]
        public StudentModel Get(int StudentId)
        {
            try
            {
                var student = _studentService.Get(StudentId);
                return student;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentModel studentModel)
        {
            try
            {
                var result = _studentService.Insert(studentModel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] StudentModel studentModel)
        {
            try
            {
                var result = _studentService.Update(studentModel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _studentService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
