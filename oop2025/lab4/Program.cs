using System;
using System.IO;
using System.Globalization;

namespace Test {
    class Program {
        static void Main(string[] args) {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            // Чтение данных из файла
            int N = Convert.ToInt32(Console.ReadLine());
            String? str_all = Console.ReadLine();
            if (str_all == null) str_all = "";
            string[] str_elem = str_all.Split(' ');
            double[] mas = new double[N];
            
            for (int i = 0; i < N; i++) {
                mas[i] = Convert.ToDouble(str_elem[i], CultureInfo.InvariantCulture);
            }

            // Вычисление среднего арифметического отрицательных элементов
            double sum_negative = 0;
            int count_negative = 0;
            for (int i = 0; i < N; i++) {
                if (mas[i] < 0) {
                    sum_negative += mas[i];
                    count_negative++;
                }
            }
            double avg_negative = 0;
            if (count_negative > 0) {
                avg_negative = sum_negative / count_negative;
            }

            // Вычисление среднего арифметического положительных элементов
            double sum_positive = 0;
            int count_positive = 0;
            for (int i = 0; i < N; i++) {
                if (mas[i] > 0) {
                    sum_positive += mas[i];
                    count_positive++;
                }
            }
            double avg_positive = 0;
            if (count_positive > 0) {
                avg_positive = sum_positive / count_positive;
            }

            // Вывод средних арифметических
            Console.WriteLine(String.Format("{0:0.000000}", avg_negative));
            Console.WriteLine(String.Format("{0:0.000000}", avg_positive));

            // Поиск элементов между средними арифметическими
            double min_avg = Math.Min(avg_negative, avg_positive);
            double max_avg = Math.Max(avg_negative, avg_positive);
            
            bool first = true;
            for (int i = 0; i < N; i++) {
                if (mas[i] > min_avg && mas[i] < max_avg) {
                    if (!first) {
                        Console.Write(" ");
                    }
                    Console.Write(String.Format("{0:0.000000}", mas[i]));
                    first = false;
                }
            }
            Console.WriteLine();

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}

