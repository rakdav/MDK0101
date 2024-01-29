using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class OrArray:IArray
    {
        public int[] Mas { get; set; }
        public OrArray(int size)
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
            var result = Mas.Union(mas.Mas);
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
                res += String.Format($"{Math.Log(i):F2} ");
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
