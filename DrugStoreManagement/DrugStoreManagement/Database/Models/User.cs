using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fin { get; set; }
        public User(string name, string surname, string fin)
        {

            Name = name;
            Surname = surname;
            Fin = fin;
        }

    }
}
