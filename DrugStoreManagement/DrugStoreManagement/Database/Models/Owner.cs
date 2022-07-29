using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    public class Owner : User
    {
        public Owner(string firstname,string surname,string fin)
            :base(firstname,surname,fin)
        {

        }
    }
}
