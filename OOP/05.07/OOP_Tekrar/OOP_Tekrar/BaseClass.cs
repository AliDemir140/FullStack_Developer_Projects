namespace OOP_Tekrar
{
    public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
