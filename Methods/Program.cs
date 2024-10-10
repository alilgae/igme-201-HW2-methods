/*
 * Jin Yi (A) & Kaiden Terrana (B)
 * IGME 201.01.01 - Interac Des & Alg Prob Sol III
 * Due Oct 13, 2024
 */
using System.ComponentModel;

namespace Methods
{
    internal class Program
    {

        /// <summary>
        /// Partner A's add method 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Add(int x, int y)
        {
            {
                return x + y;
            }
        }
        static void Main(string[] args)
            {
                // Variables 
                int jinsFavoriteNumber;
                int kaidensFavoriteNumber;

                // Initialize
                jinsFavoriteNumber = 25;
                kaidensFavoriteNumber = 36;

                // Start of our actual program, Logic
                Console.WriteLine("Jin's favorite number is " + jinsFavoriteNumber);
                Console.WriteLine("Kaiden's favorite number is " + kaidensFavoriteNumber);

                // Methods
                // Subtract two numbers
                int Subtract(int a, int b)
                {
                    return a - b;
                }

                // Call methods
                /// uncomment these lines vvv when you put your variable in 
                int addedNumbers = Add(jinsFavoriteNumber, kaidensFavoriteNumber);
                Console.WriteLine("When we add our favorite numbers from each other we get: " + addedNumbers);
                int subtractedNumbers = Subtract(jinsFavoriteNumber, kaidensFavoriteNumber);
                Console.WriteLine("When we subtract our favorite numbers from each other we get: " + subtractedNumbers);

            }

    }
}   
