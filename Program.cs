using System;
using System.Collections.Generic;

namespace Task1
{
    // Інтерфейс IShape з методом Draw
    interface IShape
    {
        void Draw();
    }

    // Інтерфейс IColoredShape успадковується від IShape
    interface IColoredShape : IShape
    {
        void SetColor(string color);
    }

    // Клас Circle реалізує IColoredShape
    class Circle : IColoredShape
    {
        private string color = "білий";
        private int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void Draw()
        {
            Console.WriteLine("Коло з радіусом " + radius + ", колір: " + color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо список IShape
            List<IShape> shapes = new List<IShape>();

            // Створюємо кола з різними кольорами
            Circle c1 = new Circle(5);
            c1.SetColor("червоний");

            Circle c2 = new Circle(10);
            c2.SetColor("синій");

            Circle c3 = new Circle(7);
            c3.SetColor("зелений");

            // Додаємо в список
            shapes.Add(c1);
            shapes.Add(c2);
            shapes.Add(c3);

            // Виводимо опис кожної фігури
            Console.WriteLine("=== Список фігур ===");
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }
    }
}
