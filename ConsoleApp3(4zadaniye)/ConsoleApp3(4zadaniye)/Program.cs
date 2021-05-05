using System;

namespace ConsoleApp3_4zadaniye_
{
    class Money
    {
        private int first;//номинал купюры
        private int second; //количество купюр

        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }



        public int FIRST
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public int SECOND
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public void Displayinfo()
        {

            Console.WriteLine($"номинал купюры = {first}\nколичество купюр = { second}");
            
        }
        public void IsEnough()
        {

            Console.WriteLine("Введите стоимость товара для проверки");
            int cost = int.Parse(Console.ReadLine());
            if (first * second >= cost)
            {
               
                Console.WriteLine("хватает");
            }
            else
            {
               
                Console.WriteLine("не хватает");
            }
            
        }

        public void Productquantity()
        {
            Console.WriteLine("Введите стоимость товара для расчета количества допустимого обьема ");
            int cost = int.Parse(Console.ReadLine());
            int n = 1;
            while (n * cost <= first * second)
            {

                n++;

            }
            Console.WriteLine($"можно купить { n - 1} у.е. товара ");
        }

        public int Total
        {
            get
            {

                return first * second;
            }


            private set { }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номинал купюры: ");
            int first = Testcheck();
            Console.Write("Введите количество купюр: ");
            int second = Testcheck();

            Money currency = new Money(first, second);
            
            currency.Displayinfo();
            currency.IsEnough();
            currency.Productquantity();

            Console.ReadKey();
        }
        static int Testcheck()
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
