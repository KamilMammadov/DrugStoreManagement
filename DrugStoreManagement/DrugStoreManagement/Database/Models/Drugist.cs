using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    class Drugist : User
    {
        public string Education { get; set; }
        public string Experience { get; set; }
        public Drugist(string firstname, string surname, string fin,string education,string experience)
           : base(firstname, surname, fin)
        {
            Education = education;
            Experience = experience;
        }
    }
}
