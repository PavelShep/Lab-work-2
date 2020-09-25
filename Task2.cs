using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i=1; i<=N; i++){
                sum = sum + i;
            }

            Console.WriteLine("Cумма всех натуральных чисел от 1 до " + N + ": " + sum);
        }
    }
}
