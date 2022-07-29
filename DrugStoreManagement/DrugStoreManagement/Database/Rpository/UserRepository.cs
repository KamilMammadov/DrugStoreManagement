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

        public static List<User> GetAll()
        {
            return Users;
        }

        public static List<Owner> GetOwners()
        {
            List<Owner> owners = new List<Owner>();
            foreach (User user in Users)
            {
                if (user is Owner)
                {
                    owners.Add((Owner)user);
                }
            }

            return owners;
        }

        public static List<Drugist> GetDrugists()
        {
            List<Drugist> drugists = new List<Drugist>();
            foreach (User user in Users)
            {
                if (user is Drugist)
                {
                    drugists.Add((Drugist)user);
                }
            }

            return drugists;
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }







    }
}
