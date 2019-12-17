using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace BiEntropyLib.Benchmarks
{
    public class Config :ManualConfig
    {
        public Config()
        {
            Add(Job.LegacyJitX64);
            Add(Job.LegacyJitX86);
            Add(Job.RyuJitX64);
        }
    }
}