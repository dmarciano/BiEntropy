using BenchmarkDotNet.Running;

namespace BiEntropyLib.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Benchmark>();
        }
    }
}