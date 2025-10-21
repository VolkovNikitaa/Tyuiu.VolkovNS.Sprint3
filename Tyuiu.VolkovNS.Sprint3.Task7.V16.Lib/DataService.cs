using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolkovNS.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) {
                if (i == 0.4) { break;}
                result[count] = Math.Round(Math.Cos(i)/(i-0.4) + Math.Sin(i)*8*i+2,2);
                count++;
            }

            return result;
        }
    }
}
