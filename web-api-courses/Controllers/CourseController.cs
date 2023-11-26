using Microsoft.AspNetCore.Mvc;
using web_api_courses.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private static List<Course> courses=new List<Course>();
        static int count = 0;
        // GET: api/<CourseController>/5/?
        [HttpGet]
        public List<Course> Get(string? name, int? age)
        {
            return courses.Where(c => (c.Name == name || name== null) && (c.Age >= age || age == null)).ToList();
        }
        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            Course? course = courses.Find(c => c.Id == id);
            if (course == null)
                throw new Exception("404");
            return course;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            course.Id = ++count;
            courses.Add(course);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course course)
        {
            Course? res = courses.Find(c => c.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = course.Name;
            res.Address = course.Address;
            res.MeetingNum = course.MeetingNum;
            res.Age = course.Age;
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Course? course = courses.Find(c => c.Id == id);
            if (course == null)
                throw new Exception("404");
            courses.Remove(course);
        }
    }
}
