using Courses.Core.Servises;
using Microsoft.AspNetCore.Mvc;
using web_api_courses.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

         // GET: api/<CourseController>/5/?
        [HttpGet]
        public List<Course> Get(string? name, int? age)
        {
            return _courseService.GetAll(name,age);
        }
        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return _courseService.GetById(id);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            _courseService.Post(course);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course course)
        {
            _courseService.Put(id, course);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _courseService.Delete(id);
        }
    }
}
