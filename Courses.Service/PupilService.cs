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
    public class PupilService : IPupilService
    {
        private readonly IPupilRepository _pupilRepository;
        public PupilService(IPupilRepository pupilRepository)
        {
            _pupilRepository = pupilRepository;
        }

        public void AddYear(int id)
        {
            Pupil? res = _pupilRepository.GetList().Find(p => p.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Age++;
        }

        public void Delete(int id)
        {
            Pupil? pupil = _pupilRepository.GetList().Find(c => c.Id == id);
            if (pupil == null)
                throw new Exception("404");
            _pupilRepository.GetList().Remove(pupil);
        }

        public List<Pupil> GetAll()
        {
            return _pupilRepository.GetList();
        }

        public Pupil GetById(int id)
        {
            Pupil? pupil = _pupilRepository.GetList().Find(p => p.Id == id);
            if (pupil == null)
                throw new Exception("404");
            return pupil;
        }

        public void Post(Pupil pupil)
        {
            pupil.Id = _pupilRepository.GetCount();
            _pupilRepository.GetList().Add(pupil);
        }

        public void Put(int id, Pupil pupil)
        {
            Pupil? res = _pupilRepository.GetList().Find(p => p.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = pupil.Name;
            res.Address = pupil.Address;
            res.Age = pupil.Age;
            res.Phone = pupil.Phone;
        }

    }
}
