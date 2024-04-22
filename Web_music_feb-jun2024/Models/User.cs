using System.ComponentModel.DataAnnotations;

namespace Web_music_feb_jun2024.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User(string nickname, string email, string password)
        {
            Nickname = nickname;
            Email = email;
            Password = password;
            Role = Role.User;
        }
    }
    public enum Role
    {
        User,
        Moderator,
        Administrator
    }
}
