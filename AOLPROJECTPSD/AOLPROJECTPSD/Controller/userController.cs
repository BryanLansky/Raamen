using AOLPROJECTPSD.Handler;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Controller
{
    public class userController
    {
        //public static int randomSeller()
        //{
            
        //}
        public static String createUser(String Username, String Email, String Password, String Gender, int Role, String ConfirmPassword)
        {
            if (Username == null || Email == null || Password == null || Gender == null || Role == 0 || ConfirmPassword == null)
            {
                return "Data not inserted";
            }
            else if (!(Username.Length >= 5 && Username.Length <= 15))
            {
                return "Username Length must be between 5-15!";
            }
            else if (!(Email.EndsWith(".com")))
            {
                return "Email Must ends with '.com'";
            }
            else if (Gender.Equals(""))
            {
                return "Gender must be chosen!";
            }
            else if (!(Password.Equals(ConfirmPassword)))
            {
                return "Must be the same with Confirm Password";
            }
            userHandler.createUser(Username, Email, Password, Gender, Role);
            return "User Registered";
        }

        public static String Login(String Username, String Password, bool isChecked)
        {
            if (Username.Equals("") || Password.Equals(""))
            {
                return "Data must be filled";
            }
            else if (userHandler.getUserByUsername(Username) == null)
            {
                return "User not found";
            }
            else if (!(userHandler.getUserByUsername(Username).Password.Equals(Password)))
            {
                return "Incorrect Password";
            }
            return "User Logged on";
        }
        public static User getUserByUsername(string username)
        {
            return userHandler.getUserByUsername(username);
        }
        public static List<User> getAllUserByRole(int id)
        {
            return userHandler.getAllUserByRole(id);
        }
        public static User getUser(int id)
        {
            return userHandler.getUser(id);
        }
        //public static Boolean updateProfile(int id, string username, string email, string gender, string password)
        //{
        //    return userHandler.updateUser(id, username, email, gender, password);
        //}
        public static String updateProfile(int id, string username, string email, string gender, string password, string ConfirmPassword)
        {
            if (username == null || email == null || password == null || gender == null || ConfirmPassword == null)
            {
                return "Data not inserted";
            }
            else if (!(username.Length >= 5 && username.Length <= 15))
            {
                return "Username Length must be between 5-15!";
            }
            else if (!(email.EndsWith(".com")))
            {
                return "Email Must ends with '.com'";
            }
            else if (gender.Equals(""))
            {
                return "Gender must be chosen!";
            }
            else if (!(password.Equals(ConfirmPassword)))
            {
                return "Must be the same with Confirm Password";
            }
            if (userHandler.updateUser(id, username, email, gender, password) == false)
            {
                return "User Not Found";
            }
            else
            {
                return "berhasil";
            }
        }
        public static User GetUserByIDandRoleId(int ID, int RoleID)
        {
            return userHandler.GetUserByIDandRoleId(ID, RoleID);
        }
    }
}