using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Parent
{
    public class UpdateParentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomeAddress { get; set; }
        public ICollection<Entities.Concrete.Student> Childs { get; set; }
    }
}
