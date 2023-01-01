using System;

namespace Bilge_College.Models.Entities.Abstract
{

    public enum Status { Active = 1, Modified,Passive}
    public class BaseEntity
    {
        public int Id { get; set; }
  
        public DateTime CreateDate
        {
            get;
            set;
        } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
