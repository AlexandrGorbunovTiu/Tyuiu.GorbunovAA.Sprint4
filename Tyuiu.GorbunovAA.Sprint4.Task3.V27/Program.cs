using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService()
            Console.Title = "Спринт #4 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Вынолнил: Горбунов Александр Александрович │ ИИПб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму всех нечетных значений в массиве                        *");
            Console.WriteLine("* и вывести это значение                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Известный нам массив                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[,] { { 4, 3, 5, 5, 3 }, { 6, 7, 4, 4, 3 }, { 3, 3, 7, 3, 6 }, { 3, 4, 3, 7, 7 }, { 3, 5, 6, 3, 6 } };
            Console.WriteLine(" Сумма нечетных элементов в массиве - " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
