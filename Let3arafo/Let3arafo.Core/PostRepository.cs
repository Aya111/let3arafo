using Let3arafo.Data.DatabaseSpecific;
using Let3arafo.Data.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SK.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View.DtoClasses;
using View.Persistence;

namespace Let3arafo.Core
{
    public class PostRepository :ISinglton
    {
        public async Task<Result<List<Post>>> Get()
        {
            var adapter = new DataAccessAdapter();

            var meta = new LinqMetaData(adapter);

            var posts = await meta.Post.Where(x => x.IsActive).ProjectToPost().ToListAsync();

            return Result<List<Post>>.True(posts);
        }
    }
}