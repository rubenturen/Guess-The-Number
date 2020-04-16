using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace guessthenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int num = random.Next(1, 100);

            int guess;
            int attempts = 0;

            outer:

            Console.WriteLine("choose a number between 1 and 100");

            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != num)
            {
                if (guess > num)
                {
                    Console.WriteLine("the number was to large");
                    attempts = attempts + 1;
                    goto outer;
                }
                else
                {
                    Console.WriteLine("the number was to small");
                    attempts = attempts + 1;
                    goto outer;
                }
                
            }
            Console.WriteLine("you guessed the number it took you " + attempts + " attempts");
            return;
            
        }
    }
}
