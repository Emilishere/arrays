
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 21, 27, 32, 46, 58, 78, 88, 93, 95  };
            int enteredvalue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == enteredvalue)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
