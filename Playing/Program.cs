using System;
using System.Text;

namespace Playing
{
    class Program
    {
        private static int choice;
        private static QuadRoots quadEqn;
        private static string phrase;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Would you like to reverse a string [1] or calculate roots of a quadratic eq'n [2]? [1 / 2] ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        ReverseIt();
                        goto Cont;
                    case 2:
                        quadEqn = new QuadRoots();
                        quadEqn.CalculateRoots();
                        goto Cont;
                    default:
                        Console.WriteLine("Exiting.");
                        goto Finish;
                }
            Finish:
                break;
            Cont:
                continue;
            } while (true);
        }

        private static void ReverseIt()
        {
            string esarhp;
            Console.Write("Enter a string you'd like to reverse:\n\t");
            phrase = Console.ReadLine();

            foreach (char letter in phrase)
            {
                esarhp = esarhp.Insert(0, letter.ToString());
            }
        }

    }
}
