namespace Bilge_College.Models.DTOs.ParentNotice
{
    public class AddParentNoticeDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AdminId { get; set; }
        public Entities.Concrete.Admin Admin { get; set; }
        public int ParentId { get; set; }
        public Entities.Concrete.Parent Parent { get; set; }
    }
}
