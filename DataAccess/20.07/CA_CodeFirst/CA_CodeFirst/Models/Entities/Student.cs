namespace CA_CodeFirst.Models.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        //Bir Student içerisinde birden fazla Course olabilir.

        public List<StudentAndCourse> StudentCourses { get; set; }
    }
}
