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

            // Чтение данных из файла и инициализация массива
            // и сразу выводим исходную
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[N, M];
            
            for (int i = 0; i < N; i++) {
                String? str_all = Console.ReadLine();
                if (str_all == null) str_all = "";
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++) {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j]);
                    if (j < M - 1) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Ищем и выводим максимальные отрицательные элементы для строк
            int[] max_negative = new int[N];
            for (int i = 0; i < N; i++) {
                int max_neg = int.MinValue;
                bool found_negative = false;
                for (int j = 0; j < M; j++) {
                    if (mas[i, j] < 0) {
                        if (!found_negative || mas[i, j] > max_neg) {
                            max_neg = mas[i, j];
                            found_negative = true;
                        }
                    }
                }
                max_negative[i] = found_negative ? max_neg : int.MinValue;
                Console.WriteLine(max_negative[i]);
            }

            // Вывод модифицированной матрицы
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    if (mas[i, j] > max_negative[i]) {
                        Console.Write("-");
                    } else {
                        Console.Write("+");
                    }
                    if (j < M - 1) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}

