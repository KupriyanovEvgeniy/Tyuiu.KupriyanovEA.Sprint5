using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KupriyanovEA.Sprint5.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил Куприянов Е. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Куприянов Евгений Александрович | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, Дана функция на заданном диапазоне [-5;5]     *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль     *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить  *");
            Console.WriteLine("* до двух знаков после запятой.                                           *");
            Console.WriteLine("*                  2 + Cos(x)                                             *");
            Console.WriteLine("* F(x) = 4 - 2x + ------------                                            *");
            Console.WriteLine("*                     2x-2                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
