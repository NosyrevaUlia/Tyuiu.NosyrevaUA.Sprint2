using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y - x * x >= 0) && (y - Math.Pow(Math.E, x) <= 0) && (y - Math.Pow(Math.E, -x) <= 0))
            {
                return true;
            }
            else { return false; }
        }
    }
}
