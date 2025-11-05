namespace CA_Polymorphism
{
    internal class Kedi:Hayvan
    {
        //bir kedinin ....'sı olur.

        public bool NankorMu { get; set; }

        //Metot => Ses çıkarma eylemini temsil edecek.

        public override void SesCikar()
        {
            Console.WriteLine("miyavvvv");
        }
    }
}
