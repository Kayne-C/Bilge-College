﻿using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class TeacherClassroomRepository : BaseRepository<TeacherClassroom>, ITeacherClassroomRepository
    {
        public TeacherClassroomRepository(BilgeDbContext bilgeDbContext) : base(bilgeDbContext)
        {
        }
    }
}