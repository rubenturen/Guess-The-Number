using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine("choose a number between 1 and 100");

            guess = Convert.ToInt32(Console.ReadLine());

            while (guess != num)
            {
                if (guess > num)
                {
                    Console.WriteLine("the number was to large the number was " + num);
                    return;
                }
                else
                {
                    Console.WriteLine("the number is to small the number was " + num);
                    return;
                }
                
            }
            Console.WriteLine("you guessed the number");
            return;

        }
    }
}
