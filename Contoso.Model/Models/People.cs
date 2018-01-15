using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class People : AuditableEntity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MiddleName { get; set; }
        public String Email { get; set; }
        public String City { get; set; }
        public DateTime? DateBirth { get; set; }

        public String State { get; set; }
        public String ZipCode { get; set; }
        public String Phone { get; set; }
    }
}
