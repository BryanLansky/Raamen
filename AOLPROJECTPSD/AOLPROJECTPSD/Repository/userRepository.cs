using AOLPROJECTPSD.Factory;
using AOLPROJECTPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AOLPROJECTPSD.Repository
{
    public class userRepository
    {
        static DBEntities1 db = new DBEntities1();
        //CRUD USER
        //1. Create

        //public static int randomSeller()
        //{
        //    List<User> allSeller = getAllUserByRole(2);
            
        //}
        public static void createUser(String Username, String Email, String Password, String Gender, int Role)
        {
            User user = userFactory.createUser(Username, Email, Password, Gender, Role);
            db.Users.Add(user);
            db.SaveChanges();
            return;
        }
        //2. Read
        public static User getUser(int userId) // cari satu user
        {
            User user = db.Users.Find(userId);
            return user;
        }
        public static User getUserByUsername(String Username)
        {
            User u = (from data in db.Users where data.Username.Equals(Username) select data).FirstOrDefault();
            return u;
        }
        public static List<User> getAllUserByRole(int roleId) // ambil semua data user sesuai role
        {
            List<User> allUsers = db.Users.ToList();
            List<User> userList = new List<User>();
            foreach(User user in allUsers)
            {
                if(user.RoleId == roleId)
                {
                    userList.Add(user);
                }
            }
            return userList;
        }
        //3. Update
        public static Boolean updateUser(int userId, string username, string email, string gender, string password)
        {
            User updatedUser = getUser(userId);
            if(updatedUser != null)
            {
                updatedUser.Username = username;
                updatedUser.Email = email;
                updatedUser.Gender = gender;
                updatedUser.Password = password;
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        //4. Delete
        public static Boolean deleteUser(int userId)
        {
            User deletedUser = getUser(userId);
            if (deletedUser != null)
            {
                db.Users.Remove(deletedUser);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static User GetUserByIDandRoleId(int ID, int RoleID)
        {
            User u = (from data in db.Users where db.Users.Any(x => x.Id.Equals(ID) && x.RoleId.Equals(RoleID)) select data).FirstOrDefault();
            return u;
        }
    }
}