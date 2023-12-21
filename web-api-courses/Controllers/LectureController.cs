using Courses.Core.Servises;
using Microsoft.AspNetCore.Mvc;
using web_api_courses.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;
        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        // GET: api/<LectureController>
        [HttpGet]
        public List<Lecture> Get(string? name, string? city)
        {
            return _lectureService.GetAll(name, city);
        }
        // GET api/<LectureController>/5
        [HttpGet("{id}")]
        public Lecture Get(int id)
        {
            return _lectureService.GetById(id);
        }

        // POST api/<LectureController>
        [HttpPost]
        public void Post([FromBody] Lecture lecture)
        {
            _lectureService.Post(lecture);
        }

        // PUT api/<LectureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lecture lecture)
        {
           _lectureService.Put(id, lecture);
        }

        // DELETE api/<LectureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _lectureService.Delete(id);
        }
    }
}
