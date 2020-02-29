using System;

namespace MOKIT_Sharp
{
    static class StatA
    {
        public static int A { get; set; } = 3;
    }

    class Program
    {
        public int EGEGEY { get; set; } = 3;
        
        private static void ArrayPlay()
        {
            //чтение переменной из консоли
            int N = Convert.ToInt32(Console.ReadLine());

            int tmp1 = N++;
            int tmp2 = ++N;
            //какие значения у tmp1 и tmp2? почему?


            //инициализация массива
            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //изначальное количество четных элементов
            int res = 0;

            //цикл foreach  
            foreach (var item in arr)
            {
                //проверка на четность (a%b - остаток от деления a на b) 
                if (item % 2 == 0)
                    //увеличиваем количество на 1, если число четное
                    res++;
            }
            //вывод результата
            Console.WriteLine(res);
        }

        //итеративная функция факториала
        protected static ulong Factorial (int value)
        {
            if (value <= 0)
                return 1;

            ulong res = 1;
            for(uint i = 2; i<= value; ++i)
            {
                res *= i; //аналогично с res = res*i;
            }
            return res;
        }

        //рекурентная функция факториала
        static long FactRec(int n)
        {
            if (n == 0) return 1;
            else return n * FactRec(n - 1);
        }

        //место для функцИЙ последовательности Фиббоначи
        //Ф(n) = Ф(n-1) + Ф(n-2)
        //Ф(1) = 1, Ф(2) = 1

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FactRec(n));
            
        }
    }

    class NewClass
    {
        //конструктор
        public NewClass()
        {
            //создание объекта
            var tmp = new Program();
            tmp.EGEGEY = 4;

            //обращение к свойству статического класса
            StatA.A = 4;
        }
    }
    
}
