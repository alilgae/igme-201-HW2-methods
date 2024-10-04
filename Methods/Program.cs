/*
 * Jin Yi (A) & Kaiden Terrana (B)
 * IGME 201
 * Due Oct 13, 2024
 */
namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            
            int kaidensFavoriteNumber;

            // Initialize

            kaidensFavoriteNumber = 36;

            // Logic

            Console.WriteLine("Kaiden's favorite number is " + kaidensFavoriteNumber);

            // Methods
            // Subtract two numbers
            int Subtract(int a, int b)
            {
                return a - b;
            }

            // Call methods

            /// uncomment these lines vvv when you put your variable in 
            //int subtractedNumbers = Subtract(jinsFavoriteNumber, kaidensFavoriteNumber);
            //Console.WriteLine("When we subtract our favorite numbers from each other we get: " + subtractedNumbers);

        }
    }
}
