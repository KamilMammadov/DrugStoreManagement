using DrugStoreManagement.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database
{
    class UserRepository
    {
        private static int _idcounter;

        public static int IDCounter
        {
            get
            {
                _idcounter++;
                return _idcounter;
            }

        }


        public static List<User> Users { get; set; } = new List<User>()
        {


        };

      

        public static User Add(User user)
        {
            Users.Add(user);
            return user;
        }
        


        public static void Delete(User user)
        {
            Users.Remove(user);
        }



        public static List<User> GetAll()
        {
            return Users;
        }


       

    }
}
