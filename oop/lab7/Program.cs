using System;
using System.IO;

namespace Test {
    class Program {
        static void Main(string[] args) {
#if !DEBUG
            Sphere s1, s2;
#else
            Sphere s2;
#endif

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

#if !DEBUG
            // Release версия: создание объектов из файла и с параметрами
            s1 = Sphere.CreateSphereFromFile();
            s1.Info();
            s2 = new Sphere(5.5);
            s2.Info();
#else
            // Debug версия: создание объекта с параметрами и вывод с цветами
            s2 = new Sphere(10.0);
            s2.Info(ConsoleColor.Yellow, ConsoleColor.Blue);
#endif

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

