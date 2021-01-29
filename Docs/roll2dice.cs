using System;

namespace Roll_2_Dice
{
    class Roll2Dice
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a number between 1 and 6: ");

            RollTwoDice(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();

        }
        static void RollTwoDice(int inputNum)
        {
            Random numberGen = new Random();
            
            int roll1 = 0;
            int roll2 = 0;
            int attempts = 0;

            
            while (roll1 != inputNum || roll2 != inputNum)
            {
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled:\n {roll1} and {roll2}\n--------------------------");
                attempts++;
            }
            Console.WriteLine("It took " + attempts + " attempts"); 

        }
    }
}
