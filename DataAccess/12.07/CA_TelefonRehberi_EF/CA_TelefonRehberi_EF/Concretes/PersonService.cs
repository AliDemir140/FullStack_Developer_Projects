using CA_TelefonRehberi_EF.Abstracts;
using CA_TelefonRehberi_EF.Models.TelefonRehberi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TelefonRehberi_EF.Concretes
{
    internal class PersonService : IPersonService
    {
        TelefonrehberiContext context = new TelefonrehberiContext();
        public void AddPerson(Person person)
        {
           
            context.Persons.Add(person);
            context.SaveChanges();
            Console.WriteLine(person.Firstname+" veritabanına eklendi!");
        }

        public void DeletePerson(int id)//2
        {



            foreach (Person p in context.Persons)
            {
                if (id == p.Id)
                {
                    context.Persons.Remove(p);
                   
                    break;
                }

            }
            context.SaveChanges();
            Console.WriteLine("kişi kaldırıldı!");
        }

        public void GetPersons()
        {
            foreach (Person person in context.Persons)
            {
                Console.WriteLine($"Ad: {person.Firstname} Soyad: {person.Lastname} Telefon No: {person.PhoneNumber}");
            }
        }
    }
}
