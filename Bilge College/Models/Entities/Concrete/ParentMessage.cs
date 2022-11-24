﻿using Bilge_College.Models.Entities.Abstract;
using System;
using System.Collections;

namespace Bilge_College.Models.Entities.Concrete
{
    public class ParentMessage : BaseEntity
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }     
    }
}
