using System;
using System.Collections.Generic;

public class Program
{
    public static int SumIntervals(int[][] intervals)
    {
        // Сортируем интервалы по началу
        List<int[]> sortedIntervals = new List<int[]>(intervals);
        sortedIntervals.Sort((a, b) => a[0].CompareTo(b[0]));

        // Объединяем интервалы
        List<int[]> merged = new List<int[]>();
        int[] current = sortedIntervals[0];

        foreach (var next in sortedIntervals)
        {
            if (current[1] >= next[0]) // Если есть пересечение
                current[1] = Math.Max(current[1], next[1]); // Объединяем
            else
            {
                merged.Add(current); // Добавляем текущий интервал в результат
                current = next; // Обновляем текущий интервал
            }
        }
        merged.Add(current); // Добавляем последний интервал

        // Считаем общую длину
        int totalLength = 0;
        foreach (var interval in merged)
            totalLength += interval[1] - interval[0];

        return totalLength;
    }

    public static void Main()
    {
        int[][] intervals = new int[][]
        {
            new int[] { 1, 4 },
            new int[] { 7, 10 },
            new int[] { 3, 5 }
        };

        Console.WriteLine("Искомое значение: " +SumIntervals(intervals));
    }
}
