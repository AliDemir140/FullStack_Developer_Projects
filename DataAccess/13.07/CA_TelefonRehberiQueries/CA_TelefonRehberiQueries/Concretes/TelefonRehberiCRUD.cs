using CA_TelefonRehberiQueries.Abstracts;
using CA_TelefonRehberiQueries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TelefonRehberiQueries.Concretes
{
    internal class TelefonRehberiCRUD : ITelefonRehberiCRUD
    {

        TelefonRehberiContext context = new TelefonRehberiContext();

        public void CreatePerson()
        {
            Console.WriteLine("Kişi oluştur");
            Console.Write("Ad: ");
            string gelenAd = Console.ReadLine();
            Console.Write("Soyad: ");
            string gelenSoyad = Console.ReadLine();
            Console.Write("Telefon No: ");
            string gelenTelefonNo = Console.ReadLine();
            if (gelenTelefonNo.Length > 11)
            {
                Console.WriteLine("Telefon no 11 karakterden büyük olamaz!");
            }




            Person person = new Person()
            {
                Firstname = gelenAd,
                Lastname = gelenSoyad,
                PhoneNumber = gelenTelefonNo
            };

            context.Persons.Add(person);
            context.SaveChanges();
        }

        public List<Person> GetList()
        {
            return context.Persons.ToList();
        }

        public Person GetPerson(string firstname)
        {
            Person person = context.Persons.FirstOrDefault(x => x.Firstname == firstname);
            return person;
        }

        public List<Person> OrderByDescById()
        {
            List<Person> people = context.Persons.OrderByDescending(x => x.Id).ToList();
            return people;
        }
    }
}
