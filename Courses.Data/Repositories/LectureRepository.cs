using Courses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Data.Repositories
{
    public class LectureRepository : ILectureRepository
    {
        private readonly DataContext _dataContext;
        public LectureRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int GetCount()
        {
            _dataContext.CountLecture++;
            return _dataContext.CountLecture;
        }

        public List<Lecture> GetList()=> _dataContext.Lectures;
        
    }
}
