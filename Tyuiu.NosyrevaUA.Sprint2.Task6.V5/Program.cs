using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Игральным картам условно присвоены следующие порядковые номера *");            
            Console.WriteLine("* в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — *");
            Console.WriteLine("* 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их      *");
            Console.WriteLine("* названиям («шестерка», «девятка» и т. п.). По заданному номеру карты k  *");
            Console.WriteLine("* (6 <=k <= 14) определить достоинство соответствующей карты.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string res;
            Console.WriteLine("Введите номер достоинства карты: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if ((k < 6) || (k > 14))
            { res = "Введено неверное значение!"; }
            else
            {
                DataService ds = new DataService();
                res = "Это карта: " + ds.FindCardValue(k);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
