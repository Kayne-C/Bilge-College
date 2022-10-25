using Bilge_College.Infrastructure.Context;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class SubSubjectRepository : BaseRepository<SubSubject>
    {
        public SubSubjectRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
