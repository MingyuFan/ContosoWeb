using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ContosoContext context) : base(context)
        {
        }

        public Instructor GetByLastName(string lastName)
        {
            var instructor = _context.Instructors.Where(i => i.LastName == lastName).FirstOrDefault();
            return instructor;
        }
    }

    public interface IInstructorRepository : IRepository<Instructor>
    {
        Instructor GetByLastName(String lastName);
    }
}
