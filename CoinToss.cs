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
            // Variable to indicate which side is up
            int sideUp;

            // Create a Random object
            Random rand = new Random();

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
                // Display head up
                Console.WriteLine("Heads");
            }
            Console.ReadLine();
        }
    }
}
