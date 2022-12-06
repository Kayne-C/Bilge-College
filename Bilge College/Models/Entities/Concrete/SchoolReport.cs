using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    
    public enum Term { BirinciDönem = 1, İkinciDönem }
    public class SchoolReport : BaseEntity
    {
        public SchoolReport()
        {
            Notes= new HashSet<Note>();
        } 
     public int StudentId { get; set; }
     public Student Student { get; set; }
     public Term Term { get; set; }
     public int AbsentDay { get; set; }
     public ICollection<Note> Notes { get; set; }
    }
}
