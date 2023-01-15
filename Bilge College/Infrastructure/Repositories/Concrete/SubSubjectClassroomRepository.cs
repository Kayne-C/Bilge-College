using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Abstract;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class SubSubjectClassroomRepository : BaseRepository<SubSubjectClassroom>, ISubSubjectClassroomRepository
    {
        readonly BilgeDbContext _bilgeDbContext;
        public SubSubjectClassroomRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
            _bilgeDbContext = bilgeDbContext;
        }

        public async Task<dynamic> SearchBoxByDayForTimeTable(string ClassroomId, string searchTerm)
        {
            return await _bilgeDbContext.SubSubjectClassrooms.Where(x => x.ClassroomId.ToString() == ClassroomId && x.Status == Status.Active).Include(x => x.SubSubject).Where(x => x.SubSubject.SubSubjectsName.Contains(searchTerm)).Include(x => x.Teacher).AsQueryable().ToListAsync();

        }

        public async Task<dynamic> SubSubjectQueryForTimeTable(string ClassroomId)
        {
            var query = _bilgeDbContext.SubSubjectClassrooms.Where(x => x.ClassroomId.ToString() == ClassroomId && x.Status == Status.Active).Include(x => x.SubSubject).Include(x => x.Teacher).AsQueryable();
            return await query.ToListAsync();

        }
    }
}
