using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISystemconfigRepository
    {

    }
    public class SystemconfigRepository : RepositoryBase<SystemConfig>, ISystemconfigRepository
    {
        public SystemconfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
