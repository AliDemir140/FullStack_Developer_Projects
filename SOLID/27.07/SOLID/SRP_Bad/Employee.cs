namespace SRP_Bad
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        internal static List<Employee> employees = new List<Employee>();
    }
}
