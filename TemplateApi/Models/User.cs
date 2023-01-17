using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } =string.Empty;
        public DateTime CratedAt { get; set; } = DateTime.Now;
    }
}