using Bilge_College.Models.Entities.Concrete;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Interfaces
{
    public interface INoteRepository : IBaseRepository<Note>
    {
        Task<dynamic> NotesQueryForTimeTable(string StudentId);
        Task<dynamic> NotesQuery(string StudentId);
        Task<dynamic> NotesQuery2(int donemId, string StudentId);
    }
}
