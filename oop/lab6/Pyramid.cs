using System;

namespace Test {
    class Pyramid {
        private double a; // сторона основания (равносторонний треугольник)
        private double h; // высота пирамиды

        // Конструктор по умолчанию
        public Pyramid() {
            a = 0;
            h = 0;
        }

        // Конструктор с параметрами
        public Pyramid(double side, double height) {
            a = side;
            h = height;
        }

        // Метод для ввода данных
        public void Load() {
            a = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
        }

        // Метод для вычисления объема
        // V = (1/3) * S_base * h = (1/3) * (a²√3/4) * h = a²h√3/12
        public double Volume() {
            return (a * a * h * Math.Sqrt(3)) / 12.0;
        }

        // Метод для вычисления площади поверхности
        // S = S_base + 3 * S_side
        // S_base = a²√3/4
        // S_side = (1/2) * a * l, где l - апофема боковой грани
        // l = √(h² + (a√3/6)²) = √(h² + a²/12)
        public double SurfaceArea() {
            double baseArea = (a * a * Math.Sqrt(3)) / 4.0;
            double lateralEdge = Math.Sqrt(h * h + (a * a) / 12.0);
            double sideArea = (a * lateralEdge) / 2.0;
            return baseArea + 3 * sideArea;
        }

        // Метод для вывода информации об объекте
        public void Info() {
            Console.WriteLine("*************************************");
            Console.WriteLine("*");
            Console.WriteLine("* правильная треугольная пирамида");
            Console.WriteLine("*");
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine($"A = {a:F2}, H = {h:F2}");
            Console.WriteLine($"V = {Volume():F2}");
            Console.WriteLine($"S = {SurfaceArea():F2}");
            Console.WriteLine();
        }
    }
}

