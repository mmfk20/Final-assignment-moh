using System;
using System.Linq;

namespace StudentCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Core Code-First demo: creating DB and adding one student...");

            using (var ctx = new SchoolContext())
            {
                ctx.Database.EnsureCreated(); // creates DB if not present

                if (!ctx.Students.Any())
                {
                    var student = new Student
                    {
                        FirstName = "Alex",
                        LastName = "Johnson",
                        EnrolledOn = DateTime.UtcNow
                    };

                    ctx.Students.Add(student);
                    ctx.SaveChanges();

                    Console.WriteLine($"Added student: {student.StudentId} {student.FirstName} {student.LastName}");
                }
                else
                {
                    Console.WriteLine("Students already present in DB:");
                    foreach (var s in ctx.Students.ToList())
                    {
                        Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName} (enrolled {s.EnrolledOn})");
                    }
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
