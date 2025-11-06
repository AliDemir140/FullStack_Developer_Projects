using CA_TelefonRehberiQueries.Concretes;
using CA_TelefonRehberiQueries.Models;

namespace CA_TelefonRehberiQueries
{
    class Program
    {
        static void Main(string[] args)
        {

            TelefonRehberiCRUD telefonRehberiCRUD = new TelefonRehberiCRUD();


            //1-Telefonrehberi veritbanını DbFirst yaklaşımı yansımasını projeye aktarın.
            //Scaffold-DbContext
            //2-Kullanıcıdan bir Person değeri isteyin Kullanıcın gridği bilgileri Person'a ekleyin.


            //telefonRehberiCRUD.CreatePerson();


            //3-Kişi (Person) adı üzerinden kullanıcdan değeri arayın.
            //Console.WriteLine("aramak istediğiniz kişi adını girin");
            //string gelenAd = Console.ReadLine();
            // Person gelenPerson=  telefonRehberiCRUD.GetPerson(gelenAd);
            //Console.WriteLine(gelenPerson.Id+" "+gelenPerson.Firstname+" "+gelenPerson.Lastname+" "+gelenPerson.PhoneNumber);
            //4-Bütün kişileri listeleyin.
            foreach (var person in telefonRehberiCRUD.GetList())
            {
                Console.WriteLine(person.Firstname+" "+person.Lastname);
            }

            Console.WriteLine("*********");

            //5-Kişileri Id'lerine göre çoktan az'a sırayın.

            foreach (var person in telefonRehberiCRUD.OrderByDescById())
            {
                Console.WriteLine(person.Firstname + " " + person.Lastname);
            }

        }
    }
}