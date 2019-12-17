using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SMC.Numerics.BiEntropy;
using System;
using System.Collections;

namespace BiEntropyLib.Benchmarks
{
    //[Config(typeof(Config))]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkWithoutCache
    {
        #region Fields
        private readonly BitArray BIT_8;
        private readonly BitArray BIT_16;
        private readonly BitArray BIT_32;
        private readonly BitArray BIT_64;
        private readonly BitArray BIT_128;
        private readonly BitArray BIT_256;
        private readonly BitArray BIT_512;
        private readonly BitArray BIT_1024;
        private readonly BitArray BIT_2048;
        private readonly BitArray BIT_4096;
        private readonly BitArray BIT_8192;
        private readonly BitArray BIT_16384;
        private readonly BitArray BIT_32768;
        private readonly BitArray BIT_65536;
        #endregion

        public BenchmarkWithoutCache()
        {
            TresBiEntropy.DisableCache();

            var rnd = new Random();
            var b = new bool[8];
            for (var i = 0; i < 8; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_8 = new BitArray(b);

            b = new bool[16];
            for (var i = 0; i < 16; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_16 = new BitArray(b);

            b = new bool[32];
            for (var i = 0; i < 32; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_32 = new BitArray(b);

            b = new bool[64];
            for (var i = 0; i < 64; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_64 = new BitArray(b);

            b = new bool[128];
            for (var i = 0; i < 128; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_128 = new BitArray(b);

            b = new bool[256];
            for (var i = 0; i < 256; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_256 = new BitArray(b);

            b = new bool[512];
            for (var i = 0; i < 512; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_512 = new BitArray(b);

            b = new bool[1024];
            for (var i = 0; i < 1024; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_1024 = new BitArray(b);

            b = new bool[2048];
            for (var i = 0; i < 2048; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_2048 = new BitArray(b);

            b = new bool[4096];
            for (var i = 0; i < 4096; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_4096 = new BitArray(b);

            b = new bool[8192];
            for (var i = 0; i < 8192; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_8192 = new BitArray(b);

            b = new bool[16384];
            for (var i = 0; i < 16384; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_16384 = new BitArray(b);

            b = new bool[32768];
            for (var i = 0; i < 32768; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_32768 = new BitArray(b);

            b = new bool[65536];
            for (var i = 0; i < 65536; i++)
                b[i] = rnd.Next(2) == 0 ? false : true;
            BIT_65536 = new BitArray(b);
        }

        #region Benchmarks
        [Benchmark]
        public double CALCULATE_BIT_8_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_8, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_16_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_16, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_32_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_32, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_64_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_64, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_128_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_128, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_256_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_256, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_512_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_512, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_1024_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_1024, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_2048_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_2048, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_4096_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_4096, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_8192_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_8192, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_16384_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_16384, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_32768_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_32768, 2, false);

        [Benchmark]
        public double CALCULATE_BIT_65536_WITHOUT_CACHE()=> TresBiEntropy.Calculate(BIT_65536, 2, false);
        #endregion
    }
}