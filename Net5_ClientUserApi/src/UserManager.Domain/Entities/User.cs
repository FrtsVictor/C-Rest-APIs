namespace UserManager.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }       
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Username { get; private set; }

        //entity framework recebe as entidades num construtor protected vazio
        protected User(){}

        public User(string name, string email, string password, string username)
        {
            Name = name;
            Email = email;
            Password = password;
            Username = username;
        }


    }
}