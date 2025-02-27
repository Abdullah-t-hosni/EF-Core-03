namespace EF_Core_03.Models
{
    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
