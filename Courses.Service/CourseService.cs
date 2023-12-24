using Courses.Core.Repositories;
using Courses.Core.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Delete(int id)
        {
            Course? course = _courseRepository.GetList().Find(c => c.Id == id);
            if (course == null)
                throw new Exception("404");
            _courseRepository.GetList().Remove(course);
        }

        public List<Course> GetAll(string? name, int? age)
        {
            return _courseRepository.GetList().Where(c => (c.Name == name || name == null) && (c.Age >= age || age == null)).ToList();
        }

        public Course GetById(int id)
        {
            Course? course = _courseRepository.GetList().Find(c => c.Id == id);
            if (course == null)
                throw new Exception("404");
            return course;
        }

        public void Post(Course course)
        {
            course.Id =_courseRepository.GetCount();
            _courseRepository.GetList().Add(course);
        }

        public void Put(int id, Course course)
        {
            Course? res = _courseRepository.GetList().Find(c => c.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = course.Name;
            res.Address = course.Address;
            res.MeetingNum = course.MeetingNum;
            res.Age = course.Age;
        }
    }
}
