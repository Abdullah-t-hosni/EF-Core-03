using System.ComponentModel.DataAnnotations;

namespace EF_Core_03.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRateBouns { get; set; }
        public int Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Course_Inst> Course_Instructors { get; set; } = new List<Course_Inst>();
    }
}
