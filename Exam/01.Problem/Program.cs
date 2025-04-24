//using System;

//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        if (N <= 0)
//        {
//            Console.WriteLine(0);
//            return;
//        }

//        int cumulativeSum = 0;
//        for (int i = 0; i < N; i++)
//        {
//            int dailyIntake = int.Parse(Console.ReadLine());
//            if (dailyIntake < 0)
//            {
//                dailyIntake = 0;
//            }
//            cumulativeSum += dailyIntake;
//            Console.WriteLine(cumulativeSum);
//        }
//    }
//}

namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int totalWaterConsume = 0;


            for (int i = 0; i < numberDays; i++)
            {
                int newWaterConsume = int.Parse(Console.ReadLine());

                if (newWaterConsume <= 0)
                {
                    Console.WriteLine("0");
                    continue;
                }
                totalWaterConsume += newWaterConsume;
                Console.WriteLine(totalWaterConsume);
            }

        }
    }
}

