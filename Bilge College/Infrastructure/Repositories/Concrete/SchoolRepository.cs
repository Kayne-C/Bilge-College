using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class SchoolReporty : BaseRepository<School>, ISchoolRepository
    {
        public SchoolReporty(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
