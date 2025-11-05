namespace LSP_Validate.Abstracts
{
    internal abstract class BaseShape
    {
        public int Edge { get; set; }

        public abstract double CalculateArea();
    }
}
