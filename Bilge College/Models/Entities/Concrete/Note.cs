using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Note : BaseEntity
    {
        public int SubSubjectId { get; set; }
        public SubSubject SubSubject { get; set; }
        public int FirstExamScore { get; set; }
        public int SecondExamScore { get; set; }
        public int AvarageScore { get; set; }     
        public int SchoolReportId { get; set; }
        public SchoolReport SchoolReport { get; set; }
    }
}
