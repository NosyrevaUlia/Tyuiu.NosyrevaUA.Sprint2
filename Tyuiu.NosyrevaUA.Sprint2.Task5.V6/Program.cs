using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие порядковые   *");
            Console.WriteLine("* номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти   *");
            Console.WriteLine("* «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — *");
            Console.WriteLine("* 13, «тузу» — 14 (порядковые номера карт остальных достоинств            *");
            Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т. п.). По заданным *");
            Console.WriteLine("* номеру масти m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14)*");
            Console.WriteLine("* определить полное название (масть и достоинство) соответствующей карты в*");
            Console.WriteLine("* виде «Дама пик», Шестерка бубен» и т. п.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string res;
            Console.WriteLine("Введите номер масти карты: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if ((m<1)||(m>4)||(k<6)||(k>14))
            { res = "Введено неверное значение!"; }
            else {
                DataService ds = new DataService();
                res = "Это карта: " + ds.FindCardNameAndValue(k,m); }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
