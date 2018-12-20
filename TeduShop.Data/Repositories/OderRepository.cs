using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOderRepository
    {

    }
    public class OderRepository : RepositoryBase<Oder>, IOderRepository
    {
        public OderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
