using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;

namespace Contoso.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentReposiroty _enrollmentRepository;
        public EnrollmentService(IEnrollmentReposiroty enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }
    }

    public interface IEnrollmentService
    {

    }
}
