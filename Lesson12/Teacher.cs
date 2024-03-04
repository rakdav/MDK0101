using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Teacher
    {
        public event ExamDelegate? examEvent;
        public void Exam(string task )
        {
            if (examEvent != null) examEvent(task);
        }
    }
}
