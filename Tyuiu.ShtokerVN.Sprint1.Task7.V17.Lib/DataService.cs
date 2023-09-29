using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.ShtokerVN.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task1V17
    {
        public double Calculate(double x, double y)
        {
            double res = 1 + Math.Sin(Math.Sqrt(Math.Pow(x , 2) + 1)) / Math.Cos(12 * y - 4);
            return Math.Round(res, 3);
        }
    }
}
