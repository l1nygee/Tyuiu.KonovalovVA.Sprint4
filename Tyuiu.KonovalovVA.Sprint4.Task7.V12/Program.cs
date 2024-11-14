﻿using Tyuiu.KonovalovVA.Sprint4.Task7.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string st = "658932125478";
            int n = 3;
            int m = 4;
            int[,] ar = new int[n, m];
            Console.Title = "Спринт #4 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int ind = 0;
            for (int i = 0; i < n*m; i++)
            {
                if (ind % 3 == 0) Console.WriteLine();
                Console.Write(st[i]+" ");
                ind++;
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(n,m,st));
        }
    }
}