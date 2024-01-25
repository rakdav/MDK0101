using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class AndArray : Array
    {
        public AndArray(int size) : base(size){}

        public override void Add(Array mas)
        {
            var result=Mas.Intersect(mas.Mas); 
            foreach(var i in result)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public override void Foreach()
        {
            foreach (var i in Mas)
            {
                Console.Write(Math.Sqrt(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
