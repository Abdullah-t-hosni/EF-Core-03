using EF_Core_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_03
{
    static class Program
    {
        static void Main()
        {
            using (var context = new ItiContext())
            {
                var department = context.Departments.FirstOrDefault(d => d.Name == "Computer Science");
                if (department == null)
                {
                    department = new Department { Name = "Computer Science", Ins_ID = 1, HiringDate = new DateTime(2022, 1, 1) };
                    context.Departments.Add(department);
                    context.SaveChanges();
                    Console.WriteLine("Department added");
                }

                // Insert Student 
                var student = new Student { FName = "abdullah", LName = "taha", Address = "Cairo", Age = 29, Dep_Id = department.ID };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added");

                // Select Data (Eager Loading)
                var students = context.Students.Include(s => s.Department).ToList();
                students.ForEach(s => Console.WriteLine($"Student: {s.FName} {s.LName}, Department: {s.Department?.Name}"));
                Console.WriteLine($"Total Students: {students.Count}");

                // Update Data
                var studentToUpdate = context.Students.FirstOrDefault();
                if (studentToUpdate != null)
                {
                    studentToUpdate.Address = "Fayoum";
                    context.SaveChanges();
                    Console.WriteLine($"Updated Student Address: {studentToUpdate.Address}");
                }

                // Delete Data
                var studentToDelete = context.Students.FirstOrDefault();
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Student deleted");
                }
            }
        }
    }
}
