using System;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
          System.Console.Write("Mata in tal 1: ");
          string input1 = Console.ReadLine();
          int num1 = Convert.ToInt32(input1);
          System.Console.Write("Mata in tal 2: ");
          string input2 = Console.ReadLine();
          int num2 = Convert.ToInt32(input2);
          int sum = num1 + num2;
          System.Console.WriteLine("Summan är {0}", sum);
        }
    }
}
