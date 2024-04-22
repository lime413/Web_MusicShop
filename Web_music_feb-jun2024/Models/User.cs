using System.ComponentModel.DataAnnotations;

namespace Web_music_feb_jun2024.Models
{
    public class User
    {
        public int Id { get; set; }

        [RegularExpression(@"^(?!.*\.\.)(?!\.)(?!.*\.$)(?!\d+$)[a-zA-Z0-9.]{5,50}$", ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Nickname { get; set; }
        [EmailAddress(ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Email { get; set; }
        [RegularExpression(@"^.*(?=.{8,})(?=.*[a-zA-Z])(?=.*\d)(?=.*[!#$%&? ""]).*$", ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<Instrument> Cart { get; set; }
        public User()
        {
            Role = Role.User;
            Cart = new List<Instrument>();
        }
        public User(string nickname, string email, string password)
        {
            Nickname = nickname;
            Email = email;
            Password = password;
            Role = Role.User;
            Cart = new List<Instrument>();
        }
    }
    public enum Role
    {
        User,
        Moderator,
        Administrator
    }
}
