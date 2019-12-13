using System;
using System.Collections;

namespace SMC.Numerics.BiEntropy
{
    internal static class Helpers
    {
        internal static int BitArrayToInteger(BitArray value)
        {
            if (value.Length > 32)
                throw new ArgumentOutOfRangeException(nameof(value), $"Argument cannot be more than 32-bits (Found: {value.Length} bits).");

            var array = new int[1];
            value.CopyTo(array, 0);
            return array[0];
        }
    }
}
