using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Soroka : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Я ем все");
        }

        public override void Go()
        {
            Console.WriteLine("Я летаю");
        }

        public override void Say()
        {
            Console.WriteLine("Я каркаю");
        }
    }
}
