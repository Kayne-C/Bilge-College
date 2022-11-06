﻿using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs
{

    public class AddClassroomDTO
    {
        public char Branch { get; set; }
        public Grade Grade { get; set; }
        public int Capacity { get; set; }
    }
}
