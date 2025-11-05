using LSP_Validate.Abstracts;

namespace LSP_Validate.Concretes
{
    internal class Rectangle:BaseShape
    {
        public int Height { get; set; }

        public override double CalculateArea()
        {
            return Height * Edge; //Dikdörtgenin alanını verir.
        }
    }
}
