using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    class OrArray : Array
    {
        public OrArray(int size) : base(size)
        {}
        public override void Add(Array mas)
        {
            var result = Mas.Union(mas.Mas);
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public override void Foreach()
        {
            foreach (var i in Mas)
            {
                Console.Write(Math.Log(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
