using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Core.Servises
{
    public interface ICourseService
    {
       List<Course> GetAll(string? name, int? age);
       Course GetById(int id);
       void Post(Course course);
       void Put(int id, Course course);
       void Delete(int id);

    }
}
