using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_music_feb_jun2024.ViewModels
{
    public class UserRegisterViewModel
    {
        [RegularExpression(@"^(?!.*\.\.)(?!\.)(?!.*\.$)(?!\d+$)[a-zA-Z0-9.]{5,50}$", ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Nickname { get; set; }

        [EmailAddress(ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Email { get; set; }

        //[RegularExpression(@"^.*(?=.{8,})(?=.*[a-zA-Z])(?=.*\d)(?=.*[!#$%&? ""]).*$", ErrorMessage = "Некорректно!")]
        [Required(ErrorMessage = "Обязательно!")]
        public string Password { get; set; }
    }
}
