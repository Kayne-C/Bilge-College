using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Parent
{
    public class AddParentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomeAddress { get; set; }
        public ICollection<Entities.Concrete.Student> Childs { get; set; }
    }
}
