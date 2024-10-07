using CalculatorWebApi.Interfaces; // Ensure correct namespace is included

namespace CalculatorWebApi.Services
{
    public class CalculatorService : ICalculatorService<int>
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }
}
