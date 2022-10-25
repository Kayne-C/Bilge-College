using Bilge_College.Infrastructure.Context;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class ParentRepository : BaseRepository<Parent>
    {
        public ParentRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
