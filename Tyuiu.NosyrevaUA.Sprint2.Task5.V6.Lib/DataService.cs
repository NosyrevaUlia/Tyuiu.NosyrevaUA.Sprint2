using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res1;
            switch (value1)
            {
                case 6:
                    res1 = "Шестерка";
                    break;
                case 7:
                    res1 = "Семерка";
                    break;
                case 8:
                    res1 = "Восьмерка";
                    break;
                case 9:
                    res1 = "Девятка";
                    break;
                case 10:
                    res1 = "Десятка";
                    break;
                case 11:
                    res1 = "Валет";
                    break;
                case 12:
                    res1 = "Дама";
                    break;
                case 13:
                    res1 = "Король";
                    break;
                case 14:
                    res1 = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value1}");
            }
            string res;
            switch (value2)
            {
                case 1:
                    res = "пик";
                    break;
                case 2:
                    res = "треф";
                    break;
                case 3:
                    res = "бубен";
                    break;
                case 4:
                    res = "червей";
                    break;
                default:
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение {value2}");
            }
            return (res1 +" "+ res);
        }
    }
}
