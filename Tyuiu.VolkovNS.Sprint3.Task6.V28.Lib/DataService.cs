﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolkovNS.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int  n=0;
            for (int i = startValue; i <= stopValue; i++)
            {      for (int j = 1; j < 7; j++)
                  if (i % j == 0)
                        n++;
            }
            return n;
        }
    }
}
