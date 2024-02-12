using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class AmmoComparator : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Monster<int> && y is Monster<int>)
            {
                var monster1 = x as Monster<int>;
                var monster2 = y as Monster<int>;
                if (monster1?.Ammo > monster2?.Ammo) return 1;
                else if (monster1?.Ammo < monster2?.Ammo) return -1;
                return 0;
            }
            throw new Exception("Невозможно сравнить");
        }
    }
}
