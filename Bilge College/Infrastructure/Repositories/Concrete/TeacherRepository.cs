using Bilge_College.Infrastructure.Context;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class TeacherRepository : BaseRepository<Teacher>
    {
        public TeacherRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
