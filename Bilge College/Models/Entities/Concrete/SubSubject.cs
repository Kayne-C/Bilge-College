﻿using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class SubSubject : BaseEntity
    {
        public string SubSubjectsName { get; set; }
        public int Score { get; set; }
        public int WeeklyClassTime { get; set; }
        public int SubSubjectCredit { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Classroom> Classrooms { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<SchoolReport> SchoolReports { get; set; }
    }
}
