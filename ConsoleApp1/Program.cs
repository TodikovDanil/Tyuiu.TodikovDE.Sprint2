using ClassLibrary1;
namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Class1 ds  = new Class1();
            Console.WriteLine("Введите значение Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.fun(x, y);
            if (res)
            {
                Console.WriteLine("Точка принадлежит заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}