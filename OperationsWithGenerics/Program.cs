using System;

namespace OperationsWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic operations!");
            ///<summary>
            ///Printing Max of integers
            ///</summary>
            int[] iArr = { 1, 2, 3, 4, 4, 0, -99 };
            GenericOperation<int> genericInt = new GenericOperation<int>(iArr);
            genericInt.PrintMax();

            ///<summary>
            ///Printing Max of doubles
            ///</summary>
            double[] dArr = { 1.9, 2.789, 32.00001, 499.00001, -4, 0, -99,009 };
            GenericOperation<double> genericDouble = new GenericOperation<double>(dArr);
            genericDouble.PrintMax();

            ///<summary>
            ///Printing Max of doubles
            ///</summary>
            string[] sArr = { "au", "kiki", "john", "lebanon", "abraham" };
            GenericOperation<string> genericString = new GenericOperation<string>(sArr);
            genericString.PrintMax();


        }

    }

    
}

