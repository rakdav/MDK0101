using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class AndArray : IArray
    {
        public int[] Mas {get; set;}
        public AndArray(int size)
        {
            Mas = new int[size];
            Random random = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = random.Next(10, 100);
            }
        }
        public string Add(IArray mas)
        {
            var result = Mas.Intersect(mas.Mas);
            string res = string.Empty;
            foreach (var i in result)
            {
                res += i + " ";
            }
            return res;
        }
        public string Foreach()
        {
            string res = string.Empty;
            foreach (var i in Mas)
            {
                res += String.Format($"{Math.Sqrt(i):F2} ");
            }
            return res;
        }
        public string Print()
        {
            string res = String.Empty;
            foreach (int i in Mas)
            {
                res += i + " ";
            }
            return res;
        }
    }
}
