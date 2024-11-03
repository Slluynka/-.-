using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Успадкування.Поліморфізм
{
     public abstract class Shape
    {
        public string name;
        public string Name { get; set; }
        public Shape(string name)
        { this.name = name; }
        public abstract double Area();
        public abstract double Perimeter();
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("circle1",5);
            Console.WriteLine(circle1.Area());
            Console.WriteLine(circle1.Perimeter());

            Circle circle2 = new Circle("circle2", 15);
            circle1.Area();
            circle1.Perimeter();
            circle2.Area();
            circle2.Perimeter();

            Square square1 = new Square("square1",10);
            Square square2 = new Square("square2", 19);
            square1.Area();
            square1.Perimeter();
            square2.Area();
            square2.Perimeter();

            if (circle1.Area() < circle2.Area())
                Console.WriteLine($"Найбільша площа у {circle2.name}");
            else Console.WriteLine($"Найбільша площа у {circle1.name}");

            if (square1.Area() < square2.Area())
                Console.WriteLine($"Найбільша площа у {square2.name}");
            else Console.WriteLine($"Найбільша площа у {square1.name}");
            Console.ReadLine();


        }
    }
    public class Circle : Shape
    {
        double radius;
        public Circle (string name, float radius) : base (name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double Area;
            Area = Math.PI * radius * radius;
            Console.WriteLine($"Площа круга {name}: {Area:F0}");
            return Area;
        }
        public override double Perimeter()
        {
            double Perimeter;
            Perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Периметр круга {name}: {Perimeter:F0}");
            return Perimeter;
        }
    }
    public class Square : Shape
    {
        double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            double Area;
            Area = side * side;
            Console.WriteLine($"Площа квадрата {name}: {Area:F0}");
            return Area;
        }
        public override double Perimeter()
        {
            double Perimeter;
            Perimeter = 4 * side;
            Console.WriteLine($"Периметр квадрата {name}: {Perimeter}");
            return Perimeter;
        }

    }

}
