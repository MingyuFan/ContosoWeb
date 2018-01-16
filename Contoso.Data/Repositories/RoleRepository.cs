using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ContosoContext context) : base(context)
        {
        }
    }

    public interface IRoleRepository : IRepository<Role>
    {

    }
}
