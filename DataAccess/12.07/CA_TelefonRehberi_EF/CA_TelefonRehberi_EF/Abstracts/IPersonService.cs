using CA_TelefonRehberi_EF.Models.TelefonRehberi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TelefonRehberi_EF.Abstracts
{
    internal interface IPersonService
    {

        //Kişilerin Listelenmesi
        void GetPersons();


        //Kişi eklenmesi
        void AddPerson(Person person);

        //Kişi kaldırılması
        void DeletePerson(int id);
    }
}
