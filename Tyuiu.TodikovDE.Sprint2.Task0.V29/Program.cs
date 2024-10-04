using System.Security.Cryptography;
using Tyuiu.TodikovDE.Sprint2.Task0.V29.Lib;
namespace Tyuiu.TodikovDE.Sprint2.Task0.V29
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #2                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            int x = 105;
            int y = 735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("X = " + x                                                                  );
            Console.WriteLine("Y = " + y                                                                  );


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}