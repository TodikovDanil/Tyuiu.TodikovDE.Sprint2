namespace ClassLibrary1
{
    public class Class1
    {
        public bool fun(double x, double y)
        {
            bool res;
            if ((y >= Math.Pow(x, 2) - 2) && (x <= 2) && (x >= -2) && (y >= -2) && (y <= 2))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
