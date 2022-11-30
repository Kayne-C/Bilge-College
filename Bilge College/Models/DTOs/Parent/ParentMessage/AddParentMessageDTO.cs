namespace Bilge_College.Models.DTOs.ParentMessage
{
    public class AddParentMessageDTO
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public int AdminId { get; set; }
        public Entities.Concrete.Admin Admin { get; set; }
        public int ParentId { get; set; }
        public Entities.Concrete.Parent Parent { get; set; }
    }
}
