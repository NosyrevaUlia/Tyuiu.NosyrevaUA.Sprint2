using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a != b + 1) | (c + 50 == 50 + d);
            res[1] = (a > b - 8) & (c - 21 != d);
            res[2] = (a <= b + 1) || (c - 92 <= d);
            res[3] = (a - 12 < b + 21) && (c + 100 > d + 101);
            res[4] = !((c + a - b) == d);
            res[5] = ((a + 7) == d) ^ (c * 4 < b/4);

            return res;

        }
    }
}
