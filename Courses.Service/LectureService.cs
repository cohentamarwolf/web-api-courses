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
    public class LectureService : ILectureService
    {
        private readonly ILectureRepository _lectureRepository;
        public LectureService(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }
        public void Delete(int id)
        {
            Lecture? lecture = _lectureRepository.GetList().Find(l => l.Id == id);
            if (lecture == null)
                throw new Exception("404");
            _lectureRepository.GetList().Remove(lecture);
        }

        public List<Lecture> GetAll(string? name, string? city)
        {
            return _lectureRepository.GetList().Where(l => (l.Name == name || name == null) && (l.City == city || city == null)).ToList();
        }

        public Lecture GetById(int id)
        {
            Lecture? lecture = _lectureRepository.GetList().Find(l => l.Id == id);
            if (lecture == null)
                throw new Exception("404");
            return lecture;
        }

        public void Post(Lecture lecture)
        {
            lecture.Id = _lectureRepository.GetCount();
            _lectureRepository.GetList().Add(lecture);
        }

        public void Put(int id, Lecture lecture)
        {
            Lecture? res = _lectureRepository.GetList().Find(l => l.Id == id);
            if (res == null)
                throw new Exception("404");
            res.Name = lecture.Name;
            res.City = lecture.City;
            res.Phone = lecture.Phone;
            res.Salary = lecture.Salary;
        }

    }
}
