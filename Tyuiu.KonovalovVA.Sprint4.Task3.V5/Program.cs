using Tyuiu.KonovalovVA.Sprint4.Task3.V5.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] ar = {{ 3, 4, 8, 6, 3 },

                        { 9, 9, 3, 6, 9 },

                        { 5, 6, 7, 2, 3 },

                        { 3, 6, 2, 3, 8 },

                        { 5, 7, 2, 6, 4}};

            Console.Title = "Спринт #4 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                    Console.Write(ar[i, j]+" ");
                Console.WriteLine("");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(ar));
        }
    }
}
