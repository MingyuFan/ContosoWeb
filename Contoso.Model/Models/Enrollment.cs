using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Enrollment : AuditableEntity
    {
        public String Grade { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }
    }
}
