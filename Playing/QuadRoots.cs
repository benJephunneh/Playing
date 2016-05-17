using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing
{
    class QuadRoots
    {
        public Roots CalculateRoots()
        {
            float[] coeffs;
            object roots;

            do
            {
                coeffs = GetCoeffs();
                if (coeffs[0].GetType() == null)
                    break;
                roots = GetRoots(coeffs);
                WriteResults();
            } while (true);
        }

        private static float[] GetCoeffs()
        {
            string a;
            float[] abc = new float[3];

            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("Input values for a, b, and c.");
            Console.Write("a: ");
            if ((a = Console.ReadLine()) == null)
            {
                Console.WriteLine("Returning.");
                return abc;
            }
            float.TryParse(a, out abc[0]);
            //float.TryParse(Console.ReadLine(), out abc[0]);

            Console.Write("b: ");
            float.TryParse(Console.ReadLine(), out abc[1]);
            Console.Write("c: ");
            float.TryParse(Console.ReadLine(), out abc[2]);

            abc[1] /= abc[0];
            abc[2] /= abc[0];
            abc[0] = 1; // x^2 + (b/a)x + (c/a) = 0

            return abc;
        }

        private static object GetRoots(float[] abc)
        {
            float D = (float)Math.Pow((abc[1] / 2), 2) - abc[2]; // D = (b/2a)^2 -c
            abc[2] = (float)Math.Pow((abc[1] / 2), 2); // x^2 + (b/a)x + (b/2a)^2 = D = (x+(b/2a))^2 = D
            complex = (D < 0) ? true : false;

            if (complex)
            {
                string cRoots = $"{-(float)Math.Sqrt(abc[2]):F4} ± {(float)Math.Sqrt(Math.Abs(D)):F4}i";
                return cRoots;
            }
            else
            {
                float[] roots = new float[2];
                roots[0] = (float)Math.Sqrt(D) - (float)Math.Sqrt(abc[2]);
                roots[1] = -(float)Math.Sqrt(D) - (float)Math.Sqrt(abc[2]);
                return roots;
            }
        }

        private static void WriteResults(object roots)
        {
            if (complex)
                Console.WriteLine($"The roots of the equation are {cRoots}.\n");
            else
                Console.WriteLine($"The roots of the equation are {roots[0]} and {roots[1]}.\n");
        }
    }
}
