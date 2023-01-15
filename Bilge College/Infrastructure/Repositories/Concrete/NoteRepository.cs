using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Abstract;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class NoteRepository : BaseRepository<Note>, INoteRepository
    {
        readonly BilgeDbContext _bilgeDbContext;
        public NoteRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
            _bilgeDbContext = bilgeDbContext;
        }

        public async Task<dynamic> NotesQueryForTimeTable(string StudentId)
        {
            var query = _bilgeDbContext.Notes.Where(x => x.SchoolReport.StudentId.ToString() == StudentId && x.SchoolReport.Status == Status.Active).Include(x => x.SubSubject).AsQueryable();
            return await query.ToListAsync();
        }

        public async Task<dynamic> NotesQuery(string StudentId)
        {
            var query = _bilgeDbContext.SchoolReports.Where(x => x.StudentId.ToString() == StudentId).Where(x => x.Status == Status.Active).Include(x => x.Student).Include(x => x.Notes).ThenInclude(x => x.SubSubject).AsQueryable();
            return await query.ToListAsync();
        }

        public async Task<dynamic> NotesQuery2(int donemId,string StudentId)
        {
            var query = _bilgeDbContext.SchoolReports.Where(x => ((int)x.Term) == donemId).Where(x => x.StudentId.ToString() == StudentId).Include(x => x.Student).Include(x => x.Notes).ThenInclude(x => x.SubSubject).AsQueryable();
            return await query.ToListAsync();
        }
    }
}
