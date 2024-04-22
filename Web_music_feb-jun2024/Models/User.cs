namespace Web_music_feb_jun2024.Models
{
    class User
    {
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User(string nickname, string email, string password, Role role)
        {
            Nickname = nickname;
            Email = email;
            Password = password;
            Role = role;
        }
    }
    class Role
    {
        public string Name { get; set; }
        public Role(string name) => Name = name;
    }
}
