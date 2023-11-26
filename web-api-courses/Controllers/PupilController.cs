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
        private static List<Pupil> pupils = new List<Pupil>();
        static int count=0;
        // GET: api/<PupilController>
        [HttpGet]
        public List<Pupil> Get()
        {
            return pupils;
        }

        // GET api/<PupilController>/5
        [HttpGet("{id}")]
        public Pupil Get(int id)
        {
            Pupil? pupil = pupils.Find(p => p.Id == id);
            if (pupil == null)
                throw new Exception("404");
            return pupil;
        }

        // POST api/<PupilController>
        [HttpPost]
        public void Post([FromBody] Pupil pupil)
        {
            pupil.Id = ++count;
            pupils.Add(pupil);
        }

        // PUT api/<PupilController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pupil pupil)
        {
            Pupil? res = pupils.Find(p => p.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = pupil.Name;
            res.Address = pupil.Address;
            res.Age=pupil.Age;
            res.Phone = pupil.Phone;
        }
        // PUT api/<PupilController>/5/age
        [HttpPut("{id}/age")]
        public void Put(int id)
        {
            Pupil? res = pupils.Find(p => p.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Age++;
        }
        // DELETE api/<PupilController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Pupil? pupil = pupils.Find(c => c.Id == id);
            if (pupil == null)
                throw new Exception("404");
            pupils.Remove(pupil);
        }
    }
}
