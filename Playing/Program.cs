using System;

namespace Playing
{
    class Program
    {
        static int choice;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Would you like to reverse a string [1] or calculate roots of a quadratic eq'n [2]? [1 / 2] ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        ReverseIt();
                        break;
                    case 2:
                        QuadRoots quadEqn = new QuadRoots();
                        quadEqn.CalculateRoots();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (true);
        }

        private static void ReverseIt()
        {
            Console.WriteLine("Enter a string you'd like to reverse:\n\t");
            Console.ReadLine();
        }

    }
}
