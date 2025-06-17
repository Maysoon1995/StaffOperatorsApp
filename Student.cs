using System.ComponentModel.DataAnnotations;

namespace StaffOperatorsApp
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
    }
}