using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {   
            GuessingGame guessingGame = new GuessingGame();
            guessingGame.GuessingG();
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
            RNumGen rNumGen = new RNumGen();
            int [] arr = rNumGen.RandomNumGen();
            int sum = 0;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }

            double mean = sum / length;

            Array.Sort(arr);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Mean: {0}",mean);
            
            if(length % 2 != 0){
                int medianplaceholder = Convert.ToInt32((length + 1) / 2);
                Console.WriteLine("Median: {0}", arr[medianplaceholder]);
            }
            else{
                int medianplaceholder = Convert.ToInt32((length + 1) / 2);
                Console.WriteLine("Median: {0}", medianplaceholder);
                double median = (arr[medianplaceholder - 1] + arr[medianplaceholder]) / 2.0;
                Console.WriteLine("Median: {0}", median);
            }
            
        }

        static void GeoAvg(){
            RNumGen rNumGen = new RNumGen();
            int [] arr = rNumGen.RandomNumGen();
            double mul = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                mul *= arr[i];
            }

           Console.WriteLine("GeometricAverage: {0}",Math.Pow(mul , 1.0/arr.Length));
        }

        static void MatricesArithmetic(){
            Console.Write("Enter no. of Rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no. of Columns");
            int c = Convert.ToInt32(Console.ReadLine());

            int [,] array1 = new int[r,c], array2 = new int[r,c], sum = new int[r,c], diff = new int[r,c];

            Console.WriteLine("Enter Values in Array1");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   array1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Values in Array2");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   array2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // calc
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   sum[i,j]  = array1[i,j] + array2[i,j];
                   diff[i,j] = array1[i,j] - array2[i,j];
                }
            }

            //result sum
            Console.WriteLine("----------------------");
            Console.WriteLine("sum:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   Console.Write(sum[i ,j]);
                   Console.Write("\t");
                }
                Console.WriteLine("");
            }

            //result Diff
            Console.WriteLine("----------------------");
            Console.WriteLine("Diff:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   Console.Write(diff[i ,j]);
                   Console.Write("\t");
                }
                Console.WriteLine("");
            }
        }

    }
}
