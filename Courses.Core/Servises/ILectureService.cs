using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Core.Servises
{
    public interface ILectureService
    {

         List<Lecture> GetAll(string? name, string? city);
         Lecture GetById(int id);
         void Post(Lecture lecture);
         void Put(int id, Lecture lecture);
         void Delete(int id);

    }
}
