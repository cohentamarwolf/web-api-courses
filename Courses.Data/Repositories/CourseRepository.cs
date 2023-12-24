using Courses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _dataContext;

        public CourseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public int GetCount()
        {
            _dataContext.CountCourse++;
            return _dataContext.CountCourse;
        }

        public List<Course> GetList() => _dataContext.Courses;

    }
}
