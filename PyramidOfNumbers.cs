//Using C# Console-App(.NetCore)

using System;

namespace Github_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variables to save entered input
            int num = default;
            
            //initializing to use random colors for the numbers, not necessary, only an extra.
            Random random = new Random();

            Console.WriteLine("Enter the height of your wished Pyramid:");
            num = int.Parse(Console.ReadLine());
            //For loop to draw a pyramid with the entered max value.
            for (int i = 0; i <= num; i++) //if you want to draw the pyramid top-down withe highest number on top, replace this line with "for (int i = num; i >= 0; i--)"
            {
                //To draw the spaces to get the right shape of a pyramid
                for (int space = 0; space < (num - i); space++)
                {
                    Console.Write(" ");
                }
                //Draw the numbers, the lowest on top and the highest on ground.
                for (int sign = 0; sign < (i * 2) - 1; sign++)
                {
                    //The row below is for giving the numbers a random chosen color, uncomment line 15 and 31.
                    //Console.ForegroundColor = (ConsoleColor)random.Next(15);
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }
}
