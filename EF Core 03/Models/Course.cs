using System.ComponentModel.DataAnnotations;

namespace EF_Core_03.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();
        public ICollection<Course_Inst> Course_Instructors { get; set; } = new List<Course_Inst>();
    }
}
