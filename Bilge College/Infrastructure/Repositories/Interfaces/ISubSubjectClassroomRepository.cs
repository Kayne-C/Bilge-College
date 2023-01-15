using Bilge_College.Models.Entities.Concrete;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Interfaces
{
    public interface ISubSubjectClassroomRepository : IBaseRepository<SubSubjectClassroom>
    {
        Task<dynamic> SearchBoxByDayForTimeTable(string ClassroomId, string searchTerm);
        Task<dynamic> SubSubjectQueryForTimeTable(string ClassroomId);
    }
}
