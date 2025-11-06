using CA_TelefonRehberi_EF.Concretes;
using CA_TelefonRehberi_EF.Models.TelefonRehberi;

namespace CA_TelefonRehberi_EF
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TelefonrehberiContext context = new TelefonrehberiContext();

            //foreach (Person person in context.Persons)
            //{
            //    Console.WriteLine($"Ad: {person.Firstname} Soyad: {person.Lastname} Telefon No: {person.PhoneNumber}");
            //}

            PersonService personService = new PersonService();

            Person p = new Person
            {
                Firstname = "Andrew",
                Lastname = "Fuller",
                PhoneNumber = "05555555555"
            };

            //personService.AddPerson(p);

            personService.GetPersons();

            personService.DeletePerson(2);

            personService.GetPersons();

        }

       
    }
}
