using System;

namespace Assignment2
{
    public class GuessingGame
    {
        public void GuessingG()
        {
            string ifcont;
            do
            {
                Console.WriteLine("Figure Out What Number I Guessed From 1 - 100");
                Console.WriteLine("You get 5 Tries! Choose Wisely");

                int myguess = new Random().Next(1, 101);
                int count = 5;
                int guessednumber;
                
                // Console.WriteLine("my guess {0}", myguess);

                do
                {
                    Console.Write("Guess a number: \t");
                    guessednumber = Convert.ToInt32(Console.ReadLine());

                    if (guessednumber == myguess)
                    {
                        Console.WriteLine("Looks like u won! GG");
                        break;
                    }
                    else if (guessednumber < myguess)
                    {
                        Console.WriteLine("Guess Something Higher , ya Noob");
                    }
                    else
                    {
                        Console.WriteLine("Ya went too high kiddo");
                    }

                    count--;
                    if (count == 0)
                    {
                        Console.WriteLine("Welp out of tries \nGo home now kiddo, run Along");
                    }
                } while (count != 0);

                Console.WriteLine("Continue Gaming (Y) / Or are u a sore Loser");
                ifcont = Console.ReadLine();
                ifcont = ifcont.ToUpper();

            } while (ifcont == "Y");

        }
    }
}