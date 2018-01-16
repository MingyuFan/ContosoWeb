using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Add(course);
            _courseRepository.SaveChanges();
        }

        public void DeleteCourse(Course course)
        {
            _courseRepository.Delete(course);
            _courseRepository.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
            _courseRepository.SaveChanges();
        }
    }

    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
    }
}
