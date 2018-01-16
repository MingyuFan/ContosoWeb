using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Role : AuditableEntity
    {
        public String RoleName { get; set; }
        public String Description { get; set; }

        public ICollection<People> Peoples { get; set; }
    }
}
