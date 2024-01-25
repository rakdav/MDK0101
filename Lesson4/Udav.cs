using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Udav : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Я ем мясо");
        }
        public override void Go()
        {
            Console.WriteLine("Я ползаю");
        }
        public override void Say()
        {
            Console.WriteLine("Я умею шипеть");
        }
    }
}
