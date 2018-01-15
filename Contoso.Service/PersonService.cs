using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public IEnumerable<People> GetAll()
        {
            return _personRepository.GetAll();
        }
    }

    public interface IPersonService
    {
        IEnumerable<People> GetAll();
    }

}
