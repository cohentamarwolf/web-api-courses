using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Core.Servises
{
    public interface IPupilService
    {
        List<Pupil> GetAll();
        Pupil GetById(int id);
        void Post(Pupil pupil);
        void Put(int id, Pupil pupil);
        void AddYear(int id);
        void Delete(int id);
    }
}
