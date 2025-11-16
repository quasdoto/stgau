using System;

namespace Test {
    // Базовый класс "Мебель"
    class Mebel {
        protected string название;  // название мебели
        protected double цена;      // цена
        protected Material материал; // материал

        // Конструктор базового класса
        public Mebel(string название, double цена, Material материал) {
            this.название = название;
            this.цена = цена;
            this.материал = материал;
        }

        // Виртуальное свойство для получения полной информации
        public virtual string ПолнаяИнформация {
            get {
                return $"Мебель: {название}, Материал: {материал}, Цена: {цена:F2} руб.";
            }
        }

        // Виртуальный метод для вывода информации
        public virtual void Info() {
            Console.WriteLine("*************************************");
            Console.WriteLine("*");
            Console.WriteLine("* " + название);
            Console.WriteLine("*");
            Console.WriteLine("*************************************");
            Console.WriteLine($"Материал: {материал}");
            Console.WriteLine($"Цена: {цена:F2} руб.");
        }

        // Базовый метод для расчета стоимости (может быть переопределен)
        public virtual double РассчитатьСтоимость() {
            return цена;
        }

        // Метод для получения типа объекта
        public virtual string ПолучитьТип() {
            return "Мебель";
        }
    }
}

