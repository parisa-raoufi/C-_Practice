using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            static void MyMethod()
            {
                string[] firstName = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
                string[] lastName = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " }; ;
                for (int i =0; i <= 10; i++)
                {
                    Console.WriteLine("enter firstName");
                    firstName[i] = Console.ReadLine();
                    Console.WriteLine("enter lastName");
                    lastName[i] = Console.ReadLine();
                    Console.WriteLine(" ");

                    for (int x = 0; x <= i; x++)
                    {
                    MyMethod2( x , firstName[x], lastName[x]);
                    }
                    Console.WriteLine(" ");

                }

            }

            static void MyMethod2( int x, string firstName , string lastName)
            {              
                Console.WriteLine( x + "_ " + firstName + " " + lastName);
            }
            MyMethod();
        }
    }
}
