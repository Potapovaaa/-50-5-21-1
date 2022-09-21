using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие которое хотите выполнить");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            int calculator = Convert.ToInt32(Console.ReadLine());
            while (calculator != 9)
            {
                if (calculator == 1)
                {
                    Console.WriteLine("введите первое число");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (a + b));
                }

               

                else if (calculator == 2)
                {
                    Console.WriteLine("введите первое число");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (c - d));

                }


                else if (calculator == 3)
                {
                    Console.WriteLine("введите первое число");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (f * n));

                }


                else if (calculator == 4)
                {
                    Console.WriteLine("введите первое число");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (e / z));
                }


                else if (calculator == 5)
                {
                    Console.WriteLine("введите первое число");
                    int s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (Math.Pow(s, l)));
                }


                else if (calculator == 6)
                {
                    Console.WriteLine("введите первое число");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (Math.Sqrt(h)));
                }


                else if (calculator == 7)
                {
                    Console.WriteLine("введите первое число");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат" + (j * 0.01));
                }


                else if (calculator == 8)
                {
                    Console.WriteLine("введите первое число");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int factorial = 0;
                    int m = 10;

                    for (int i = 1; i <= m; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("результат " + m + " = " + factorial);
                }

                Console.WriteLine("введите операцию");
                calculator = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
