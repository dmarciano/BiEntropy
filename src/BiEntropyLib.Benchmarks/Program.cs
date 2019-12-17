using BenchmarkDotNet.Running;

namespace BiEntropyLib.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var benchmarkWithCache = BenchmarkRunner.Run<BenchmarkWithCache>();
            //var benchmarkWithoutCache = BenchmarkRunner.Run<BenchmarkWithoutCache>();
        }
    }
}