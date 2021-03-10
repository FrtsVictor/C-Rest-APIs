using System;
using System.Collections.Generic;
using UserManager.Domain.Validators;

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
            _errors = new List<string>(); //instancio aqui pq vem zerada da classe Base
            Validate();
        }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);  //vem do abstract validator.validate

            if(!validation.IsValid)
            {
                foreach(var error in validation.Errors)
                     _errors.Add(error.ErrorMessage);
                     
                throw new Exception("Some fields are invalid " + _errors[0]);
            }
            
            return true;
        }                

    }
}