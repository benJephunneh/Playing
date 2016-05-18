using System;

namespace Playing
{
    class QuadRoots
    {
        private static bool complex;
        private static float[] coeffs;
        private static string[] roots;

        public void CalculateRoots()
        {
            coeffs = GetCoeffs(); // Get coefficients of ax^2 + bx + c = 0
            if (float.IsNaN(coeffs[0])) // If no coefficients were specified...
                roots = new string[1]; // ...then there are no roots.
            else
                roots = GetRoots(coeffs); // Otherwise, calculate the roots (real or complex).

            WriteResults(roots); // Write the results to console.
        }

        private static float[] GetCoeffs()
        {
            string a;
            float[] abc = new float[3];

            Console.WriteLine("\nax^2 + bx + c = 0");
            Console.WriteLine("Input values for a, b, and c.");
            Console.Write("a: ");
            if (String.IsNullOrEmpty(a = Console.ReadLine()))
            {
                Console.WriteLine("Returning.");
                return abc;
            }
            float.TryParse(a, out abc[0]);

            Console.Write("b: ");
            float.TryParse(Console.ReadLine(), out abc[1]);
            Console.Write("c: ");
            float.TryParse(Console.ReadLine(), out abc[2]);

            abc[1] /= abc[0];
            abc[2] /= abc[0];
            abc[0] = 1; // x^2 + (b/a)x + (c/a) = 0

            return abc;
        }

        private static string[] GetRoots(float[] abc)
        {
            float D = (float)Math.Pow((abc[1] / 2), 2) - abc[2]; // D = (b/2a)^2 -c
            abc[2] = (float)Math.Pow((abc[1] / 2), 2); // x^2 + (b/a)x + (b/2a)^2 = D = (x+(b/2a))^2 = D
            complex = (D < 0) ? true : false;

            if (complex)
            {
                roots = new string[1];
                roots[0] = $"{-(float)Math.Sqrt(abc[2]):F4} ± {(float)Math.Sqrt(Math.Abs(D)):F4}i";
                return roots;
            }
            else
            {
                float[] rootDouble = new float[2];
                rootDouble[0] = (float)Math.Sqrt(D) - (float)Math.Sqrt(abc[2]);
                rootDouble[1] = -(float)Math.Sqrt(D) - (float)Math.Sqrt(abc[2]);
                roots = new string[2];
                roots[0] = $"{rootDouble[0]:F4}";
                roots[1] = $"{rootDouble[1]:F4}";
                return roots;
            }
        }

        private static void WriteResults(string[] roots)
        {
            if (complex)
                Console.WriteLine($"The roots of the equation are {roots[0]}.\n");
            else
                Console.WriteLine($"The roots of the equation are {roots[0]} and {roots[1]}.\n");
            Console.ReadLine();
        }
    }
}
