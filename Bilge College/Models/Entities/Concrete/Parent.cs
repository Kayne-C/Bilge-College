using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Parent : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomeAddress { get; set; }
        public ICollection<ParentMessage> ParentMessages { get; set; }
        public ICollection<ParentNotice> ParentNotices { get; set; }
        public ICollection<StudentParent> StudentParent { get; set; }

    }
}
