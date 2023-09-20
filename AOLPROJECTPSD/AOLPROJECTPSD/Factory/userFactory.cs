using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Factory
{
    public class userFactory
    {
        public static User createUser(String Username, String Email, String Password, String Gender, int Role)
        {
            User user = new User();
            user.Username = Username;
            user.Email = Email;
            user.Password = Password;
            user.Gender = Gender;
            user.RoleId = Role;
            return user;
        }
    }
}