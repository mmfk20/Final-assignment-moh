using System;
using System.ComponentModel.DataAnnotations;

namespace StudentCodeFirst
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        public DateTime? EnrolledOn { get; set; }
    }
}
