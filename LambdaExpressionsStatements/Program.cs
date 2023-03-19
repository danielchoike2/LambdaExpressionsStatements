
using System;
using System.Security.Cryptography.X509Certificates;

namespace WorkingWithLambdaExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // Lambda Expressions
            // Add 2 numbers
            var sum = (int x, int y) => x + y;
            var product = (int x, int y) => x * y;
            var smallerValue = (int a, int b) =>
                {
                    if (a < b)
                        return a;
                    else
                        return b;

                };
            // Lambda Statements
           

            // Using lambda expressions and statements
            
            
                Console.WriteLine($"Numbers you are using: {num1}  and  {num2}");
                Console.WriteLine($"The sum is: {sum(num1, num2)}");
                Console.WriteLine($"The product is: {product(num1, num2)}");
                Console.WriteLine($"The smaller value is {smallerValue(num1, num2)}");
                Console.WriteLine();
            

        }
    }
}




