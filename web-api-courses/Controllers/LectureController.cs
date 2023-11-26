using Microsoft.AspNetCore.Mvc;
using web_api_courses.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private static List<Lecture> lectures = new List<Lecture>();
        static int count;

        // GET: api/<LectureController>
        [HttpGet]
        public List<Lecture> Get(string? name, string? city)
        {
            return lectures.Where(l =>(l.Name == name ||name==null)&&(l.City==city||city==null)).ToList();
        }
        // GET api/<LectureController>/5
        [HttpGet("{id}")]
        public Lecture Get(int id)
        {
            Lecture? lecture = lectures.Find(l => l.Id == id);
            if (lecture == null)
                throw new Exception("404");
            return lecture;
        }

        // POST api/<LectureController>
        [HttpPost]
        public void Post([FromBody] Lecture lecture)
        {
            lecture.Id = ++count;
            lectures.Add(lecture);
        }

        // PUT api/<LectureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lecture lecture)
        {
            Lecture? res = lectures.Find(l => l.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = lecture.Name;
            res.City = lecture.City;
            res.Phone = lecture.Phone;
            res.Salary = lecture.Salary;
        }

        // DELETE api/<LectureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Lecture? lecture = lectures.Find(l => l.Id == id);
            if (lecture == null)
                throw new Exception("404");
            lectures.Remove(lecture);
        }
    }
}
