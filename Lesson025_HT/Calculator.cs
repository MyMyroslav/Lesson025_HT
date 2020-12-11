using System;
namespace Lesson025_HT
{
    public class Calculator
    {
        public dynamic a;
        public dynamic b;
        public Calculator()
        {
        }
        public Calculator(dynamic a, dynamic b)
        {
            this.a = a;
            this.b = b;
        }
        public dynamic Plus (dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Minus(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Mult(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Div(dynamic a, dynamic b)
        {
            return a / b;
        }
    }
}
