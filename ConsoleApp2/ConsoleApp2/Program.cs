using System;

namespace ConsoleApp1
{
    class Rectangle
    {
        private int a;
        private int b;
       

        public int A
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
        public int B
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
        

        public bool IsRectangle
        {
            get
            {
                if ( a > 0 && b > 0  )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SquareTest
        {
            get {
                    if (a == b)
                    {
                      
                    return true;
                    
                    }
                    else
                       {
                    return false;
                   
                       }
                }
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
            
        }
        public int Perimeter()
        {
            int p = a + b ;
            return p;
        }

        public int Square()
        {
            int s = a * b;
            return s;

        }

        public void Showdata()
        {
            if (IsRectangle == true ) 
            {
                Console.WriteLine($"a = {a}\nb = {b}\n");
                if (SquareTest == true)
                {
                    
                    Console.WriteLine($"Периметр квадрата равен {Perimeter()}");
                    Console.WriteLine($"Площадь квадрата равна {Square()}");
                }
                else
                {
                    Console.WriteLine($"Периметр прямоуголника равен {Perimeter()}");
                    Console.WriteLine($"Площадь прямоуголника равна {Square()}");
                }
            }
            else 
            {
                Console.WriteLine($"Такой четырехугольник невозможен");
            }

        } 
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите длину первой стороны");
            int a = TestNumber();
            Console.WriteLine("введите длину второй стороны");
            int b = TestNumber();


            Rectangle project = new Rectangle(a, b);

            project.Showdata();
           


            Console.ReadKey();
        }

        static int TestNumber()
        {
            for (; ; )
            {
                int temp;
                string message = Console.ReadLine();
                if (Int32.TryParse(message, out temp))
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
