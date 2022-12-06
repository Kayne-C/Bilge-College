using Bilge_College.Models.DTOs.Student.Review;
using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Classroom
{

    public class AddClassroomDTO
    {
        public char Branch { get; set; }
        public Entities.Concrete.Grade Grade { get; set; }
        public int Capacity { get; set; }
    }
}
