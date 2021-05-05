using System;

namespace ConsoleApp5massiv
{
    class Array
    {
        private int[] intArray;
        private int n;
        
        public int N
        {
            get { return n; }
            private set { n = value; }
        }

        
        public int scalar
        {

            private get { return scalar; }
            set
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = value * intArray[i];
                }
            }
        }
        public Array(int n)
        {
            this.n = n;
            this.intArray = new int[n];
        }

        public int Test()
        {
            for (; ; )
            {
                int n;
               
                string message = Console.ReadLine();
                if (Int32.TryParse(message, out n))
                {

                    return n;
                }
                else
                {
                    Console.WriteLine("Введите правильное значение");
                }
            }
        }
        public void Add()
        {
            

            for (int i = 0; i < intArray.Length; i++)
            {
                
                Console.WriteLine($"введите элемент массива под номером {i} ");
                intArray[i] = Test();
            }

        }
        public void Arrayshow()
        {
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);

            }
        }

        public void Increasing()
        {
            int temp;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }

                }
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = Test();
            Array array = new Array(n);
            array.Add();
            array.Arrayshow();
            array.Increasing();
            
            array.scalar = 3;
            
            Console.WriteLine("\n"+ array.N);
            array.Arrayshow();
            Console.ReadKey();

            
        }
        static int Test()
        {
            for (; ; )
            {
                int n;
                Console.WriteLine("введите длину массива");
                string message = Console.ReadLine();
                if (Int32.TryParse(message, out n))
                {

                    return n;
                }
                else
                {
                    Console.WriteLine("Введите правильное значение");
                }
            }
        }

    }

}
