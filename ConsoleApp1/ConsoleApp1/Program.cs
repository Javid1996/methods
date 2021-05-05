using System;

namespace ConsoleApp1
{
    class Triangle 
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public bool IsTriangle 
        {
            get
            { 
                if (a + b > c && a + c > b && b + c > a && a>0 && b>0 && c>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Triangle(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    public double Perimeter ()
        {
            double p = a + b + c;
            return p;
        }
    
        public double Square( ) 
        {
            double p = Perimeter();
          return Math.Sqrt(p/2  * (p/2 - a) * (p/2  - b) * (p/2 - c));
           
        }

        public void Showdata()
        {
            if (IsTriangle == true)
            {
                Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");
                Console.WriteLine($"Периметр равен {Perimeter()}");
                Console.WriteLine($"Площадь равна {Square()}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите длину первой стороны");
            double a = TestNumber();
            Console.WriteLine("введите длину второй стороны");
            double b = TestNumber();
            Console.WriteLine("введите длину третьей стороны");
            double c = TestNumber();

            Triangle project = new Triangle( a,  b, c);
            
            project.Showdata();
            


            Console.ReadKey();
        }

        static double TestNumber()
        {
            for (; ; )
            {
                double temp;
                string message = Console.ReadLine();
                if (double.TryParse(message, out temp))
                {
                    return temp;
                }
                else
                {
                    Console.WriteLine("Введите правильное значение");
                }
            }
        }

    }
}
