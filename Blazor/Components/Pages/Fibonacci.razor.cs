using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
         int count = 10;
         List<BigInteger> fibonacciNumbers = new();

        private void GenerateFibonacci()
        {
            fibonacciNumbers.Clear();
            for (int i = 0; i < count; i++)
                fibonacciNumbers.Add(FibonacciRecursive(i));
        }

        private BigInteger FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
    
}
