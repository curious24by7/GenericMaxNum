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
            Console.ReadKey();
        }
    }
}
