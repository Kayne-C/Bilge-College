using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public enum EducationLevel { PrimarySchool = 1, HighSchool}
    public class School : BaseEntity
    {
        public string SchoolName { get; set; }
        public EducationLevel Level { get; set; }
        public int Rate { get; set; }
        public int Capacity { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
