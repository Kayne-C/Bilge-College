using System;

namespace Bilge_College.Models.Entities.Abstract
{

    public enum Status { Active = 1, Modified,Passive}
    public class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
