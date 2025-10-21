using Tyuiu.VolkovNS.Sprint3.Task7.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5, stopValue = 5;
        double[] valueArray = new double[stopValue-startValue+1];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("+---------+---------+");
        Console.WriteLine("|    X    |  f(x)   |");
        Console.WriteLine("|---------|---------|");
        for (int i = 0; i < valueArray.Length; i++) {
            Console.WriteLine("|---------|---------|");
            Console.WriteLine("|{0,5:d}    |  {1,6:f2} |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+---------+---------+");
    }
}