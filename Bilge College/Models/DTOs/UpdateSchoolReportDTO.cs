﻿using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs
{
    public class UpdateSchoolReportDTO
    {
        public ICollection<SubSubject> SubSubjects { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
