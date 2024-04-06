using System;
using static System.Math;

namespace Extended_Continued_Fraction
{
    class Program
    {

        static double a(int n)
        {
            
            return n+1;
        }

        static double b(int n)
        {
            return n;
        }

        static void Main(string[] args)
        {

            //с помощью for почленно суммируя

            /*
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

                for (int n = 0; n <= 100; n++)
                {

                    Console.WriteLine($"\ns({n}) = {s_n}");

                    s_n = s_n + Pow(-1, n) * Pow(b(n + 1), n + 1) / (q_n * q_n_1);

                    q_n_2 = a(n + 2) * q_n_1 + b(n + 2) * q_n;
                    q_n = q_n_1;
                    q_n_1 = q_n_2;

                }

                Console.WriteLine($"{1 / s_n + 2}");
            */



            // с помощью for напрямую (только с заранее заданным числом, какое вычислить)

            int to = 100;

            double s = a(to);

            for(int i = to; i >= 0; i--)
            {

                s = b(i + 1) / s + a(i);

            }
            Console.WriteLine($"\n s({to}) = {s}");

            Console.WriteLine($"\n e = {1 / s + 2}");
        }
    }
}
