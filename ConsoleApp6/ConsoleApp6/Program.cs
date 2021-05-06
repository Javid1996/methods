using System;

namespace ConsoleApp6
{
    class Array 
    {
        private int n;
        private int m;
        private double[,] DoubleArray;

        public Array(int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new double[n,m];
        }


        public int Arraylength
        {
            get { return n*m; }
            
        }

        public double Scalar
        {
            
            set {
                
                     for (int i = 0; i <n; i++)
                     {
                        for(int j=0; j< m; j++)
                        {
                            DoubleArray[i, j] += value;
                        }
                     }
                }
        }

        public void AddElements()
        {
            for (int i=0;i<n;i++)
            {
                for(int j=0; j < m; j++)
                {
                    Console.WriteLine($"Введите элемент массива { i},{j}");
                    DoubleArray[i, j] = Test2();
                }
            }
        }

        public void Displayinfo()
        {
            Console.WriteLine("Вывод массива");
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    Console.Write(DoubleArray[i, j]+" ");

                }
                Console.WriteLine();
            }
        }

        public void Decreasingsort()
        {
            double[] temparray = new double[n * m];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    temparray[m * i + j] = DoubleArray[i, j];
                }
            }
            double temp;
            
            
            for(int i=0; i < n*m; i++)
            {
                for(int j = i + 1; j < n*m; j++)
                {
                    if (temparray[i] < temparray[j])
                    {
                        temp = temparray[i];
                        temparray[i] = temparray[j];
                        temparray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    DoubleArray[i, j]=temparray[m * i + j] ;
                }
            }
        }

        static double Test2()
        {
            for (; ; )
            {
                double t;
                Console.WriteLine("введите значение  массива");
                string message = Console.ReadLine();
                if (double.TryParse(message, out t))
                {

                    return t;
                }
                else
                {
                    Console.WriteLine("Введите правильное значение");
                }
            }
        }
    }

     


    class Program
    {
        static void Main(string[] args)
        {
            int n = Test();
            int m = Test();
           
            Array M = new Array( n, m);
            M.AddElements();
            M.Displayinfo();
            M.Decreasingsort();
            M.Displayinfo();
            Console.WriteLine("\nArray length is :" + M.Arraylength);
            M.Scalar = 3;

            M.Displayinfo();
            Console.ReadKey();
        }

        static int Test()
        {
            for (; ; )
            {
                int t;
                Console.WriteLine("введите длину массива");
                string message = Console.ReadLine();
                if (Int32.TryParse(message, out t))
                {

                    return t;
                }
                else
                {
                    Console.WriteLine("Введите правильное значение");
                }
            }
        }

        
    }

}
