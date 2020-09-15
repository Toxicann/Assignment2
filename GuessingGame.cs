using System;

namespace Assignment2
{
    public class GuessingGame
    {
        public void GuessingG(){
            Console.WriteLine("Figure Out What Number I Guessed From 1 - 100");
            Console.WriteLine("You get 5 Tries! Choose Wisely: \t");

            int myguess =  new Random().Next(1 ,101);
            int count = 5;
            int guessednumber;

            do{
                Console.Write("Guess a number");
                guessednumber = Convert.ToInt32(Console.ReadLine());

                if(guessednumber == myguess){
                    Console.WriteLine("Looks like u won! GG");
                }
                else if(guessednumber < myguess){
                    Console.WriteLine("Guess Something Higher , ya Noob");
                }
                else{
                    Console.WriteLine("Ya went too high kiddo");
                }

                count--;
            }while(count != 0);
        }
    }
}