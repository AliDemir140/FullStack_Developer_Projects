namespace CA_CodeFirst.Models.Entities
{
    public class StudentAndCourse
    {
        public int StudentId { get; set; } //primary key
        public int CourseId { get; set; } //primary key

        //Mapping
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
