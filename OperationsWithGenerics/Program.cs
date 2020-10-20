using System;

namespace OperationsWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic operations!");
            MaximumInteger();
            MaximumDouble();
            MaximumString();
        }
        public static void MaximumInteger()
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int largestNumber;

            //input the numbers
            Console.Write("Enter first number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            //finding largest number 
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                largestNumber = firstNumber;
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                largestNumber = secondNumber;
            else largestNumber = thirdNumber;

            Console.WriteLine(largestNumber);
        }
        public static void MaximumDouble()
        {
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double largestNumber;

            //input the numbers
            Console.Write("Enter first number : ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number : ");
            thirdNumber = Convert.ToDouble(Console.ReadLine());

            //finding largest number 
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                largestNumber = firstNumber;
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                largestNumber = secondNumber;
            else largestNumber = thirdNumber;

            Console.WriteLine(largestNumber);
        }
        public static void MaximumString()
        {
            string firstValue;
            string secondValue;
            string thirdValue;
            string largestValue;

            //input the numbers
            Console.Write("Enter first number : ");
            firstValue = Console.ReadLine();
            Console.Write("Enter second number: ");
            secondValue = Console.ReadLine();
            Console.Write("Enter third number : ");
            thirdValue = Console.ReadLine();

            //finding largest string 
            if (firstValue.Length>secondValue.Length && firstValue.Length>thirdValue.Length)
                largestValue = firstValue;
            else if (secondValue.Length > firstValue.Length && secondValue.Length > thirdValue.Length)
                largestValue = secondValue;
            else largestValue = thirdValue;

            Console.WriteLine(largestValue);
        }
    }
}
