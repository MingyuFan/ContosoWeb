using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ContosoContext context) : base(context)
        {
        }
    }

    public interface ICourseRepository : IRepository<Course>
    {

    }
}
