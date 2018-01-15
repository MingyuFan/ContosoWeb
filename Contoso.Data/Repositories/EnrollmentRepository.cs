using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class EnrollmentRepository : Repository<Enrollment>, IEnrollmentReposiroty
    {
        public EnrollmentRepository(ContosoContext context) : base(context)
        {
        }
    }

    public interface IEnrollmentReposiroty : IRepository<Enrollment>
    {

    }
}
