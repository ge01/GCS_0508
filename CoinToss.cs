using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0508
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int sideUp;             // To indicate which side is up
            char again = 'y';       // Loop again? Y or N

            // Create a Random object
            Random rand = new Random();

            do
            {
                // Get a random integer in the range of 0 through 1
                // 0 means tails up, 1 means head up
                sideUp = rand.Next(2);

                // Display the side that is up
                if (sideUp == 0)
                {
                    // Display tails up
                    Console.WriteLine("Tails");
                }
                else
                {
                    // Display heads up
                    Console.WriteLine("Heads");
                }

                // Does the user want to run the simulation again
                Console.Write("Do you want to try again? (Y/N): ");
                again = Char.Parse(Console.ReadLine());
            } while (again == 'Y' || again == 'y');

        }
    }
}
