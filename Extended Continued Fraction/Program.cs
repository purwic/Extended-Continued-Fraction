using System;
using static System.Math;

namespace Extended_Continued_Fraction
{
    class Program
    {

        static double a(int n)
        {
            return 1;
        }
        static double b(int n)
        {
            return 2;
        }

        static void Main(string[] args)
        {

            //q_n+2 = a(n+2) * q_n+1 + b(n+2) * q_n
            //q_n_2 = a(n+2) * q_n_1 + b(n+2) * q_n

            //q_0 = 1
            double q_n = 1;

            //q_1 = a_1;
            double q_n_1 = a(1);


            double q_n_2;

            double s_n = a(0);


            //0

            //s_1 = s_0 + ...
            //s_n = s_n + Pow(-1, 0) * Pow(b(0+1), 0+1) / (q_n * q_n_1);

            //Console.WriteLine($"n = 0; s(0) = {s_n}");

            //q_n_2 = a(0 + 2) * q_n_1 + b(0 + 2) * q_n;
            //q_n = q_n_1;
            //q_n_1 = q_n_2;

            for(int n = 0; n <= 100; n++)
            {
                s_n = s_n + Pow(-1, n) * Pow(b(n + 1), n + 1) / (q_n * q_n_1);

                Console.WriteLine($"\ns({n}) = {s_n}");

                q_n_2 = a(n + 2) * q_n_1 + b(n + 2) * q_n;
                q_n = q_n_1;
                q_n_1 = q_n_2;

            }

        }
    }
}
