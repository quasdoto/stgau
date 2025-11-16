using System;
using System.IO;

namespace Test {
    class Program {
        static void Main(string[] args) {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

            Pyramid p = new Pyramid();
            p.Load();
            p.Info();

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}

