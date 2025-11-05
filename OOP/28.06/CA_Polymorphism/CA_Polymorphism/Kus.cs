namespace CA_Polymorphism
{
    internal class Kus:Hayvan
    {
        public bool KonusurMu { get; set; }

        public override void SesCikar()
        {
            Console.WriteLine("cik cik");
        }
    }
}
