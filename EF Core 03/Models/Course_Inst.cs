namespace EF_Core_03.Models
{
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public double Evaluate { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
