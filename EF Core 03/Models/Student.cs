using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_03.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }

}
