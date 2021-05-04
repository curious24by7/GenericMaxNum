using System;

namespace GenericMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Max Number is ::");
            int Output = MaxNumCheck.MaxIntNum(10, 20, 30);
            Console.WriteLine(Output);
            Console.WriteLine("The Max Number in Float is ::");
            double DoubleOutput = MaxNumCheck.MaxFloatNum(50.2, 30.9, 60.50);
            Console.WriteLine(DoubleOutput);
            Console.WriteLine("The Max Number in String is ::");
            string StringOP = MaxNumCheck.MaxStringNum("50", "110", "111");
            Console.WriteLine(StringOP);
            Console.ReadKey();
        }
    }
}
