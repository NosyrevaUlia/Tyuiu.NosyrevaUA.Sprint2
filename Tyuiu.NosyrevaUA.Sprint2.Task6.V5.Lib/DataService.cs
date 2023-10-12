using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            string s;
            switch(value)
            {
                case 6: return "Шестерка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: throw new ArgumentException($"Достоинство должно быть от 6 до 14. Значение {value}"); ;
                

            }
        }
    }
}
