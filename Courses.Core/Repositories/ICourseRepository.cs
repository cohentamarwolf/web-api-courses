using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Core.Repositories
{
    public interface ICourseRepository
    {
        int GetCount();
        List<Course> GetList();

    }
}
