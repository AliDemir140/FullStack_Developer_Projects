using CA_TelefonRehberiQueries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TelefonRehberiQueries.Abstracts
{
    internal interface ITelefonRehberiCRUD
    {
        public void CreatePerson();
       public  Person GetPerson(string firstname);

        List<Person> GetList();

        List<Person> OrderByDescById();
    }
}
