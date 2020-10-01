using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a____Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers, and this program will output the sum.");
            Console.ReadLine();

            int firstNumber, secondNumber, thirdNumber, totalSum;

            Console.WriteLine("First, please enter your first number.");
            firstNumber =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now, enter your second number.");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finally, enter your third number");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            totalSum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine($"The sum of all of your numbers is {totalSum}.");
            Console.ReadLine();
        }
    }
}
