using System.ComponentModel;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
            
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
            
        }

        public int Divide(int a, int b)
        {
            if (b <= 0) 
                throw new InvalidOperationException("No se puede dividir de 0 o numero negativos.");
            return a / b;
        }
    }
}