using Login_Form_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form_MVC.Controller
{
    class UserController
    {
        public Boolean ValidLogin(string name,string surname,string username,string password)
        {
            User usr = new User(name,surname,username,password);
            if (usr.IsNullValues())
            {
                return true;
            }
            else return false;

        }

    }
}
