using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        public Instructor GetByLastName(string lastName)
        {
            return _instructorRepository.GetByLastName(lastName);
        }
    }

    public interface IInstructorService
    {
        Instructor GetByLastName(String lastName);
    }
}
