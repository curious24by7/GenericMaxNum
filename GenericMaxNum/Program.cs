using System;
using System.Linq;

namespace GenericMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30 };
            double[] doubleArray = { 50.2, 30.9, 60.50 };
            string[] stringArray = { "50", "85", "10" };
            GenericMax<int> genericInt = new GenericMax<int>(intArray);
            genericInt.PrintmaxValue();
            GenericMax<double> genericDouble = new GenericMax<double>(doubleArray);
            genericDouble.PrintmaxValue();
            GenericMax<string> genericString = new GenericMax<string>(stringArray);
            genericString.PrintmaxValue();
            Console.ReadKey();
        }

    }
}
