using System;

namespace Lesson025_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            dynamic a = 12;
            dynamic b = 6;
            Calculator calculator = new Calculator(a,b);
            Console.WriteLine(calculator.Plus(a,b));
            Console.WriteLine(calculator.Minus(a, b));
            Console.WriteLine(calculator.Mult(a, b));
            Console.WriteLine(calculator.Div(a, b));
        }
    }
}
