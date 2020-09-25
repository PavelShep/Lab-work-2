using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (b < 0){
                b = -b;
            }

            for (int i=1; i<=b; i++){
                sum = sum + a;
            }

            Console.WriteLine("Произведение: " + sum);
        }
    }
}
