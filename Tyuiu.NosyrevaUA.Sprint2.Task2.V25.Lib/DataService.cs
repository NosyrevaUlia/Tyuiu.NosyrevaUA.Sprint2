using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
           if ((x<14) && ((y>2) && (y<13)))
            {
                if((x == 1||x == 2) && (y==5||y==6))
                { return true; }

                else if ((x>2 && x<6) && ((y>2 && y<8) || (y == 11)))
                { return true; }

                else if (((x>5 && x<9) && (y>4 && y<9)) || ((x>5 && x<8) && (y>4 && y<12)) || (x == 7 && y == 12))
                { return true; }

                else if (((x>8 && x<13) && (y>2 && y<9)) || ((x>9 && x<12) && (y>8 && y<12)) || (x == 10 && y == 12))
                { return true; }

                else if ((x == 13) && (y>5 && y<9))
                { return true; }
                else { return false; }
            }
           else { return false; }


        }
    }
}
