using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Department : AuditableEntity
    {
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }

        public Nullable<int> InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
