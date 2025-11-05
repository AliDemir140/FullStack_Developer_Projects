using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    internal class Hayvan//Base
    {
        public string Cins { get; set; }
        public string Renk { get; set; }
        public string Boy { get; set; }
        public string Kilo { get; set; }

        //Polymorphism=> çok biçimli davranması gerekmetekdir.
            //virtual=> o yapının miras verilen class içerisinde isteğe bağlı davranışının değiştirilmesini temsil eder. isteğe bağlı ezilibilir öğe olduğunu temsil eder.

            //override=> virtual oalrak işaretlenmiş bir öğeyi ezilmesini (davranışının değiştirilmesi) sağlar.
        public virtual void SesCikar()
        {
            Console.WriteLine("tanımlı ses");
        }
    }
}
