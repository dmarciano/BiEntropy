using System;
using System.Collections;
using System.Threading;

namespace SMC.Numerics.BiEntropy
{
    public static class Helpers
    {
        private static Func<BitArray, int, double> BinaryDerivativeDelegate = (value, k) =>
        {
            var derivative = BinaryDerivative(value, k);
            var ones = 0;
            for (var i = 0; i < derivative.Count; i++)
                if (derivative[i]) ones++;

            return ones / (double)derivative.Count;
        };

        public static BitArray BinaryDerivative(BitArray value)
        {
            try
            {
                var result = new bool[value.Length - 1];
                for (var index = 0; index < value.Length - 1; index++)
                    result[index] = value[index] ^ value[index + 1];

                return new BitArray(result);
            }
            catch
            {
                return new BitArray(0);
            }
        }

        public static BitArray BinaryDerivative(BitArray value, int k)
        {
            try
            {
                if (0 == k) return value;
                if (1 == k) return BinaryDerivative(value);

                return BinaryDerivative(BinaryDerivative(value, k - 1));
            }
            catch
            {
                return new BitArray(0);
            }
        }

        public static double CalculateP(BitArray value, int k, DerivativeCache<double> cache = null)
        {
            if (null == cache)
                return BinaryDerivativeDelegate(value, k);
            else
                return cache.GetOrCreate(new MultiKey(value, k), BinaryDerivativeDelegate).GetAwaiter().GetResult();
        }

        public static int BitArrayToInteger(BitArray value)
        {
            if (value.Length > 32)
                throw new ArgumentOutOfRangeException(nameof(value), $"Argument cannot be more than 32-bits (Found: {value.Length} bits).");

            var array = new int[1];
            value.CopyTo(array, 0);
            return array[0];
        }

        public static double Add(ref double location1, double value)
        {
            double newCurrentValue = location1;
            while (true)
            {
                double currentValue = newCurrentValue;
                double newValue = currentValue + value;
                newCurrentValue = Interlocked.CompareExchange(ref location1, newValue, currentValue);
                if (newCurrentValue == currentValue)
                    return newValue;
            }
        }
    }
}