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
        public override string Add(Array mas)
        {
            var result = Mas.Union(mas.Mas);
            string res = string.Empty;
            foreach (var i in result)
            {
                res += i + " ";
            }
            return res;
        }
        public override string Foreach()
        {
            string res = string.Empty;
            foreach (var i in Mas)
            {
                res +=String.Format($"{Math.Log(i):F2} ");
            }
            return res;
        }
    }
}
