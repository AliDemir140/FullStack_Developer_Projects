namespace CA_CodeFirst.Models.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Bir Course'un birden fazla Student olur.

        public List<StudentAndCourse> StudentCourses { get; set; }
    }
}
