using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 0)
            {
                y = x + Math.Pow((x + 3) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = (x*x - Math.Cos(x*x) + 10) / (x*x - Math.Sin(x*x) + 12);
            }
            else if (x<0 && x>(-26))
            {
                y = Math.Pow(3 + 2/(x*x), x);
            }
            else if (x<(-21))
            {
                y = x + 10*x - 1/x;
            }
            else { y = 0; };
           
            return Math.Round(y,3);

        }
    }
}
