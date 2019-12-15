using System;
using System.Collections;

namespace SMC.Numerics.BiEntropy
{
    public static class Helpers
    {
        public static BitArray BinaryDerivative(BitArray value)
        {
            try
            {
                var result = new bool[value.Length - 1];
                for (var index = 0; index < value.Length - 1; index++)
                    result[index] = value[index] ^ value[index + 1];

                return new BitArray(result);//.Some();
            }
            catch
            {
                return new BitArray(0);// Option.None<BitArray>();
            }
        }

        public static BitArray BinaryDerivative(BitArray value, int k)
        {
            try
            {
                if (0 == k) return value;
                if (1 == k) return BinaryDerivative(value);

                return BinaryDerivative(BinaryDerivative(value, k - 1));//.ValueOr(new BitArray(0)));
            }
            catch
            {
                return new BitArray(0);
            }
        }

        public static double CalculateP(BitArray value, int k)
        {
            var derivative = BinaryDerivative(value, k);
            var ones = 0;
            for (var i = 0; i < derivative.Count; i++)
                if (derivative[i]) ones++;

            return ones / (double)derivative.Count;
        }

        public static int BitArrayToInteger(BitArray value)
        {
            if (value.Length > 32)
                throw new ArgumentOutOfRangeException(nameof(value), $"Argument cannot be more than 32-bits (Found: {value.Length} bits).");

            var array = new int[1];
            value.CopyTo(array, 0);
            return array[0];
        }
    }
}