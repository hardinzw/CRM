using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class User
    {
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
