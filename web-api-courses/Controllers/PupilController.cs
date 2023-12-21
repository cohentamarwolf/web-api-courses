using Courses.Core.Servises;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using web_api_courses.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilController : ControllerBase
    {
        private readonly IPupilService _pupilService;
        public PupilController(IPupilService pupilService)
        {
            _pupilService = pupilService;
        }

        // GET: api/<PupilController>
        [HttpGet]
        public List<Pupil> Get()
        {
            return _pupilService.GetAll();
        }

        // GET api/<PupilController>/5
        [HttpGet("{id}")]
        public Pupil Get(int id)
        {
            return _pupilService.GetById(id);
        }

        // POST api/<PupilController>
        [HttpPost]
        public void Post([FromBody] Pupil pupil)
        {
            _pupilService.Post(pupil);
        }

        // PUT api/<PupilController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pupil pupil)
        {
            _pupilService.Put(id, pupil);
        }
        // PUT api/<PupilController>/5/age
        [HttpPut("{id}/age")]
        public void Put(int id)
        {
           _pupilService.AddYear(id);
        }
        // DELETE api/<PupilController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _pupilService.Delete(id);
        }
    }
}
