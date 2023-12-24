using Courses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_api_courses.Entities;

namespace Courses.Data.Repositories
{
    public class PupilRepository : IPupilRepository
    {
        private readonly DataContext _dataContext;
        public PupilRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int GetCount()
        {
            _dataContext.CountPupil++;
            return _dataContext.CountPupil;
        }

        public List<Pupil> GetList() => _dataContext.Pupils;
       
    }
}
