using System;

class Program
{
    static void Main()
    {
        int[] dailyAmounts = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();

        int startDay = int.Parse(Console.ReadLine());
        int endDay = int.Parse(Console.ReadLine());

        int sumBeforeDivision = 0;

        double sumRain = 0;        
        double counter = 0.00;

        for (int i = startDay; i <= endDay; i++)
        {
            int dailyRain = dailyAmounts[i];

            sumBeforeDivision += dailyRain;

            sumRain += dailyRain;

            counter++;

        }

        sumRain /= counter;

        Console.WriteLine(sumBeforeDivision);

        Console.WriteLine($"{sumRain:f2}");

    }
}
