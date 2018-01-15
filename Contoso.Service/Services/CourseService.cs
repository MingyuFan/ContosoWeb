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
        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }
    }

    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
    }
}
