using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public IEnumerable<People> GetAll()
        {
            return _peopleRepository.GetAll();
        }
    }

    public interface IPeopleService
    {
        IEnumerable<People> GetAll();
    }

}
