using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TodikovDE.Sprint2.Task3.V14.Lib
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x - Math.Pow((x + 1) / (x - 1), 3);
            }
            else
            {
                if  (x == 0)
                {
                     y = (Math.Pow(3 * x, 2) - Math.Pow(Math.Cos(x),3) + 10) / (Math.Pow(4 * x,2) - Math.Pow(Math.Sin(x),4) +12);
                }
                else
                {
                    if ((x > -18) && (x < 2))
                    {
                        y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
                    }
                    else
                    {
                        if (x < -18)
                        {
                            y = x + 10 * x - 1 / x;
                        }
                    }
                }
            }
            return Math.Round(y,3);
        
        }
    }
}
