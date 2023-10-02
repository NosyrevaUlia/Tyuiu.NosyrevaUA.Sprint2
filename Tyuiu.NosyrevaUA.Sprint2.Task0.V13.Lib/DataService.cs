using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 0 == y;
            res[1] = x - 0 != y;
            res[2] = x < y - 9;
            res[3] = x > 67 + y;
            res[4] = x <= 80 - y;
            res[5] = x >= y - 90;

            return res;
        }
    }
}
