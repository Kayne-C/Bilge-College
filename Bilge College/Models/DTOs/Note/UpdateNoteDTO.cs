using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Models.DTOs.Note
{
    public class UpdateNote
    {
        public int FirstExamScore { get; set; }
        public int SecondExamScore { get; set; }
        public int AvarageScore { get; set; }
    }
}
