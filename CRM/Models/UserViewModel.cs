namespace CRM.Models
{
    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public User() { }

    }
}
