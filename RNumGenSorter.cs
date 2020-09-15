using System;

namespace Assignment2
{
    public class RNumGenSorter
    {
        public int [] RandomNumGen(){
            Console.WriteLine("Enter the total no of numbers to generate");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Range of numbers to generate form:\n Ex: for 1-100, enter 1 & enter 100");
            int lRange = Convert.ToInt32(Console.ReadLine());
            int uRange = Convert.ToInt32(Console.ReadLine());

            int [] randomNumbers = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                randomNumbers[i] = new Random().Next(lRange, uRange + 1);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Random Numbers");
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            return randomNumbers;
        }

        public void NumSorter(){

        }
    }
}

