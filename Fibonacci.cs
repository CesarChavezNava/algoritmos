namespace Fibonacci
{
    class Program
    {
        static Dictionary<int, long> _memo =
            new() { { 0, 0 }, { 1, 1 } };

        static void Main(string[] args)
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine($"Fib({i}) = {Fib(i)}");
            }
        }

        static long Fib(int n)
        {
            if (_memo.ContainsKey(n))
                return _memo[n];

            var value = Fib(n - 1) + Fib(n - 2);

            _memo[n] = value;

            return value;
        }
    }
}