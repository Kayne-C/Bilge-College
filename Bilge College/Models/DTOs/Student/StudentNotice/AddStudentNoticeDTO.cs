using System;

namespace Bilge_College.Models.DTOs.Student.StudentNotice
{
    public class AddStudentNoticeDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AdminId { get; set; }
        public Entities.Concrete.Admin Admin { get; set; }
        public int StudentId { get; set; }
        public Entities.Concrete.Student Student { get; set; }
        public DateTime CreateDate { get; set; }
        public string TimeAgo { get; set; }
    }
}
