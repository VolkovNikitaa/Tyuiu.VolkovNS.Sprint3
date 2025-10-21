using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolkovNS.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y=0;
            for (int i = startValue; i < stopValue; i++) {
                if (i == 0) {  break; }
            y+= i/(Math.Cos(i)-Math.Sin(i));
            }
            return Math.Round(y,3);
        }
    }
}
