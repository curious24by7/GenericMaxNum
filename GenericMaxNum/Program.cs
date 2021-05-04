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

            Program.MaxNum<int>(intArray);
            Program.MaxNum<double>(doubleArray);
            Program.MaxNum<string>(stringArray);


            Console.ReadKey();
        }
        public static void MaxNum<T>(T[] inputArray)
        {
            var m = inputArray.Max();
            Console.WriteLine(m);
            Console.WriteLine("------------------------");
        }
    }
}
