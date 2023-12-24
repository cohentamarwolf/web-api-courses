using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Data
{
    public class DataContext
    {
        public List<Course> Courses { get; set; }
        public int CountCourse { get; set; }
        public List<Lecture> Lectures { get; set; }
        public int CountLecture { get; set; }
        public List<Pupil> Pupils { get; set; }
        public int CountPupil { get; set; }
        public DataContext()
        {
            Courses = new List<Course>();
            Lectures = new List<Lecture>();
            Pupils = new List<Pupil>();
            CountCourse = 0;
            CountLecture = 0;
            CountPupil = 0;
        }
    }
}
