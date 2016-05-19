using System;

namespace Playing
{
    internal class ReverseIt
    {
        private static string phrase;
        private static string esarhp;

        public void DoIt()
        {
            Console.Write("Enter a string you'd like to reverse:\n\t");
            phrase = Console.ReadLine();
            phrase.ToCharArray();
            char[] temp = new char[phrase.Length];

            for (int i = phrase.Length; i > 0; i--) // D'oh!  Could have used Array.Reverse(temp)
            {
                temp[Math.Abs(i - phrase.Length)] = phrase[i - 1];
            }
            esarhp = new string(temp);

            Console.WriteLine($"Original:\t{phrase}");
            Console.WriteLine($"Modified:\t{esarhp}");
            Console.ReadLine();
        }
    }
}