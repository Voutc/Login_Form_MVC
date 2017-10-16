using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form_MVC.Models
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //Constructor με ορίσματα.
        public User(string _name, string _surname, string _username, string _password)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.Username = _username;
            this.Password = _password;
        }
        //Έλεγχος για το αν το Username και το Pass είναι οι τιμές που θέλω.
        public bool IsTrueData()
        {
            if (Username == "Fotis" && Password == "123") return true;
            else return false;
        }
        //Έλεγχος για το αν το Name και το Surname είναι κενά.
        public bool IsNullValues()
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname) || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return true;
            }
            else return false;
        }


    }
}
