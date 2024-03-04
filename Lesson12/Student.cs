using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public void Exam(string task )
        {
            Console.WriteLine($"Студент {LastName} сдал предмет {task}");
        }
    }
}
