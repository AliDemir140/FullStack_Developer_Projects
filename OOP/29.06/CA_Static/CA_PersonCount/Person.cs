namespace CA_PersonCount
{
    internal class Person
    {
        public Person()
        {
            Count++;
        }
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public static int Count { get; set; }//0
    }
}
