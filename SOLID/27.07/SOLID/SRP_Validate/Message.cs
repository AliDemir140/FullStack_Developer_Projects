namespace SRP_Validate
{
    internal class Message
    {
        internal static void Karsilama()
        {
            Console.WriteLine("Hoşgeldiniz!");
        }

        internal static void ErrorMessage(string propertyName)
        {
            Console.WriteLine($"{propertyName} boş geçilemez!");
        }

    }
}
