using Bilge_College.Models.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.SchoolReport
{
    public class AddSchoolReportDTO
    {
        public int StudentId { get; set; }
        public Entities.Concrete.Student Student { get; set; }
        public Term Term { get; set; }
        public int AbsentDay { get; set; }
        public ICollection<Entities.Concrete.Note> Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TimeAgo { get; set; }
    }
}
