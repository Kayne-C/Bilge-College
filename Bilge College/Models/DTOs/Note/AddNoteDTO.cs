﻿using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Models.DTOs.Note
{
    public class AddNoteDTO
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