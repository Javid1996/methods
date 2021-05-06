using System;

namespace ConsoleApp0
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x=0 ,int y=0 )
        {
            this.x = x;
            this.y = y;
        }

        
        public void Displayinfo()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        public double Distance()
        {
            
            return Math.Sqrt(x * x) + (y * y);

        }

        public void Displacement(int a , int b) 
        {
           
            x += a;
            y += b;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int scalX 
        {
            set 
            {
                x *= value; 
            }
        }

        public int scalY
        {
            set
            {
                y *= value;
            }
        }


       

    }

    class Program
    {


        static void Main(string[] args)
        { int a = AddVector();
            int b = AddVector();
            int x=Addpoint();
            int y=Addpoint();
            Point p = new Point(x,y);
            Console.WriteLine("вывести координаты точки на экран:");
            p.Displayinfo();
            Console.Write("расстояние от начала координат до точки:");
            p.Distance();
            p.Displacement();
            
            

            Console.ReadKey();


        }
            static int Addpoint()
        {
            Console.WriteLine("Введите координаты точки ");
     
            for(; ; )
            {
                int temp;
                string message = Console.ReadLine();
            if(Int32.TryParse(message, out temp))
                {
                    return temp;
                }
                else
                {
                    Console.WriteLine("Введите корректные данные");
                }
            }
       
        }

        static int AddVector()
        {
            Console.WriteLine("Введите координаты вектора ");

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
                    Console.WriteLine("Введите корректные данные");
                }
            }
        }
    }
}
