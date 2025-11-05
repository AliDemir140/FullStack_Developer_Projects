namespace CA_Abstraction
{
    public abstract class Enstruman //Abstract
    {
        /*
         bir nesneyi abstract olarak işaretlediğimizde o nesneden instance alınamaz!!!
         BaseClass olarak kullanılacak nesneler abstract olarak tanımlanmalıdır.
         abstract işaretlenen bir class statik olarak tanımlanamazlar!
         eğer bir metod abstract olarak işaretlendiyse o metodun gövdesi açılmaz. Gövdesi miras alındığı yerde açılmak zorundadır!!!
         */
        public string Marka { get; set; }

        //public virtual string Cal()
        //{
        //    return "tanımlı enstruman çalınıyor...";
        //}

        public abstract string Cal();
    }
}