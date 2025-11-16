using System;
using System.Globalization;

namespace Test {
    class Sphere {
        private double r; // радиус шара

        // Конструктор по умолчанию (приватный)
        private Sphere() {
            r = 0;
        }

        // Конструктор с параметром (радиус)
        public Sphere(double radius) {
            r = radius;
        }

        // Статический метод для создания объекта из файла
        public static Sphere CreateSphereFromFile() {
            string? input = Console.ReadLine();
            double radius = double.Parse(input ?? "0", CultureInfo.InvariantCulture);
            return new Sphere(radius);
        }

        // Метод для ввода данных
        public void Load() {
            string? input = Console.ReadLine();
            r = double.Parse(input ?? "0", CultureInfo.InvariantCulture);
        }

        // Метод для вычисления объема
        // V = (4/3) * π * r³
        public double Volume() {
            return (4.0 / 3.0) * Math.PI * r * r * r;
        }

        // Метод для вычисления диаметра
        // D = 2 * r
        public double Diameter() {
            return 2 * r;
        }

        // Метод для вычисления площади поверхности
        // S = 4 * π * r²
        public double SurfaceArea() {
            return 4 * Math.PI * r * r;
        }

        // Метод для вывода информации об объекте (без параметров)
        public void Info() {
            Console.WriteLine("*************************************");
            Console.WriteLine("*");
            Console.WriteLine("* шар");
            Console.WriteLine("*");
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine($"R = {r:F2}, D = {Diameter():F2}");
            Console.WriteLine($"V = {Volume():F2}");
            Console.WriteLine($"S = {SurfaceArea():F2}");
            Console.WriteLine();
        }

        // Перегруженный метод Info с параметрами цветов
        public void Info(ConsoleColor fg, ConsoleColor bg) {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Clear();
            Info(); // Вызываем базовый метод Info()
        }
    }
}

