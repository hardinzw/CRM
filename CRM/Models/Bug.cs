using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
    }
}
