using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOderDetailRepository : IRepository<OrderDetail>
    {

    }
    public class OderDetailRepository : RepositoryBase<OrderDetail>, IOderDetailRepository
    {
        public OderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
