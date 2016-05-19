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
            Console.Write("Enter a string you'd like to reverse:\n\t");
            string phrase = Console.ReadLine();
            phrase.ToCharArray();
            char[] temp = new char[phrase.Length];

            for (int i = phrase.Length; i > 0; i--) // D'oh!  Could have used Array.Reverse(temp)
            {
                temp[Math.Abs(i - phrase.Length)] = phrase[i - 1];
            }
            string esarhp = new string(temp);

            Console.WriteLine($"Original:\t{phrase}");
            Console.WriteLine($"Modified:\t{esarhp}");
            Console.ReadLine();
        }

    }
}
