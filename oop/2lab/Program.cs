using System;
using System.IO;

namespace Test {
    class Program {
        static void Main(string[] args) {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double a, b, c, d, e;
            double s, k;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((c - a < 0) || (b - Math.Sqrt(c - a) <= 0) || (e <= 0)) {
                Console.WriteLine("ERROR");
            } else {
                s = a / Math.Sqrt(b - Math.Sqrt(c - a)) + c / Math.Sqrt(e);
                Console.WriteLine(String.Format("{0:0.000}", s));
            }

            if ((2 * c - a < 0) || (c - 2 * b <= 0)) {
                Console.WriteLine("ERROR");
            } else {
                double numerator = a - Math.Sqrt(2 * c - a);
                double denominator = Math.Sqrt(c - 2 * b);
                if (numerator / denominator < 0) {
                    Console.WriteLine("ERROR");
                } else {
                    k = Math.Sqrt(numerator / denominator);
                    Console.WriteLine(String.Format("{0:0.000}", k));
                }
            }

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}