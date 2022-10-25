using Bilge_College.Infrastructure.Context;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}
