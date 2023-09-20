using AOLPROJECTPSD.Factory;
using AOLPROJECTPSD.Model;
using AOLPROJECTPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Handler
{
    public class userHandler
    {
        public static void createUser(String Username, String Email, String Password, String Gender, int Role)
        {
            userRepository.createUser(Username, Email, Password, Gender, Role);
            return;
        }

        public static User getUser(int userId)
        {
            return userRepository.getUser(userId);
        }

        public static User getUserByUsername(String Username)
        {
            return userRepository.getUserByUsername(Username);
        }
        public static List<User> getAllUserByRole(int roleId)
        {
            return userRepository.getAllUserByRole(roleId);
        }

        public static Boolean updateUser(int userId, string username, string email, string gender, string password)
        {
            return userRepository.updateUser(userId, username, email, gender, password);
        }

        public static Boolean deleteUser(int userId)
        {
            return userRepository.deleteUser(userId);
        }
        public static User GetUserByIDandRoleId(int ID, int RoleID)
        {
            return userRepository.GetUserByIDandRoleId(ID, RoleID);
        }
    }
}