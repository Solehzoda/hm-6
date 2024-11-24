using System;

namespace homework_lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var result = a >= 10 && a <= 99 && a % 2 == 0;
            Console.WriteLine(result);
        }
    }
}