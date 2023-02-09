using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber= 0;
            int secondNumber = 1;
            int thirdNumber;
            for (int i =0; i <= 100; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
