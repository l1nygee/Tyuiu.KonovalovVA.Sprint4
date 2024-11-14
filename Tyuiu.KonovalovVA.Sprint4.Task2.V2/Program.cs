using Tyuiu.KonovalovVA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] ar = new int[11];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("Введите" + i + "-ый элемент");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Title = "Спринт #4 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < ar.Length; i++) Console.WriteLine(ar[i]);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(ar)- 549);
        }
    }
}
