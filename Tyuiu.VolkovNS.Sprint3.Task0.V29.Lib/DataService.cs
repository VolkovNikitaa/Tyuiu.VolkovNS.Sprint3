using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolkovNS.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int startvalue; startValue <= stopValue; startValue++)
            {
                s += (Math.Pow(value, 2 * startValue) + 1.0 / (startValue + 1)) * Math.Cos(value);
            }
            return Math.Round(s,3);
        }
    }
}
