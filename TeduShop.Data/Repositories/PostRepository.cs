using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetMultiPaging(Func<Post, bool> p, out int totalRow, int page, int pagesize);
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetMultiPaging(Func<Post, bool> p, out int totalRow, int page, int pagesize)
        {
            throw new NotImplementedException();
        }
    }
}
