using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double average = CalculateAverage(array);
        Console.WriteLine($"Среднеарифметическое: {average}");
        double percentage = CalculatePercentageAboveAverage(array, average);
        Console.WriteLine($"Процент элементов, превышающих среднеарифметическое: {percentage}%");
    }
    static double CalculateAverage(int[] array)
    {
        double sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum / array.Length;
    }
    static double CalculatePercentageAboveAverage(int[] array, double average)
    {
        int countAboveAverage = 0;

        foreach (int number in array)
        {
            if (number > average)
            {
                countAboveAverage++;
            }
        }

        return ((double)countAboveAverage / array.Length) * 100;
    }
}
