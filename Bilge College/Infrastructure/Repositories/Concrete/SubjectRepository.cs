using Bilge_College.Infrastructure.Context;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class SubjectRepository : BaseRepository<Subject>
    {
        public SubjectRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
