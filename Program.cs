using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {   
            MeanMedian();
        }

        static void MulTable()
        {
            Console.WriteLine("Enter A number for multiplication");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication Table for {0}", number);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static void MeanMedian(){
            RNumGenSorter rNumGenSorter = new RNumGenSorter();
            int [] test = rNumGenSorter.RandomNumGen();
            int sum = 0;
            double length = test.Length;

            for (int i = 0; i < length; i++)
            {
                sum += test[i];
            }

            double mean = sum / length;
            Console.WriteLine("Mean: {0}",mean);
            
        }


    }
}
