using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {
        public PeopleRepository(ContosoContext context) : base(context)
        {
        }

        public People GetByLastName(string lastname)
        {
            var people = _context.People.Where(p => p.LastName == lastname).FirstOrDefault();
            return people;
        }
    }

    public interface IPeopleRepository : IRepository<People>
    {
        People GetByLastName(String name);
    }
}
