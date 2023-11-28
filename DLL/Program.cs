using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = MyFunctions.Add(5, 3);
            Console.WriteLine("Результат сложения: " + result);

            int fact = MyFunctions.Factorial(5);
            Console.WriteLine("Факториал числа 5: " + fact);

            MyFunctions.ReadFile("input.txt");

            MyFunctions.WriteFile("output.txt", "Привет, мир!");

            bool isPrime = MyFunctions.IsPrime(7);
            Console.WriteLine("Число 7 простое: " + isPrime);
        }
    }
}
