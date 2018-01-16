using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentReposiroty _enrollmentRepository;
        public EnrollmentService(IEnrollmentReposiroty enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            _enrollmentRepository.Add(enrollment);
            _enrollmentRepository.SaveChanges();
        }

        public void DeleteEnrollment(Enrollment enrollment)
        {
            _enrollmentRepository.Delete(enrollment);
            _enrollmentRepository.SaveChanges();
        }

        public IEnumerable<Enrollment> GetAll()
        {
            return _enrollmentRepository.GetAll();
        }

        public Enrollment GetEnrollmentById(int id)
        {
            return _enrollmentRepository.GetById(id);
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            _enrollmentRepository.Update(enrollment);
            _enrollmentRepository.SaveChanges();
        }
    }

    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAll();
        Enrollment GetEnrollmentById(int id);
        void AddEnrollment(Enrollment enrollment);
        void UpdateEnrollment(Enrollment enrollment);
        void DeleteEnrollment(Enrollment enrollment);
    }
}
