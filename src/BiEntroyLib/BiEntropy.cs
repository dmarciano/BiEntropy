using System;
using System.Collections;
using System.Linq;
using static SMC.Numerics.BiEntropy.Helpers;
using static System.Math;

namespace SMC.Numerics.BiEntropy
{
    public static class BiEntropy
    {
        public static double Calculate(byte value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(new byte[] { value }), precision, useConstantIfAvailable);
        }

        public static double Calculate(BitArray value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            try
            {
                if (value.Length > 32) return TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);

                if (value.Length == 2)
                    return Constants.BIENTROPY_2BITS[BitArrayToInteger(value)];

                if (useConstantIfAvailable && (value.Length == 4 || value.Length == 8))
                {
                    var number = BitArrayToInteger(value);
                    if (value.Length == 4)
                        return Constants.BIENTROPY_4BITS[number];
                    else
                        return Constants.BIENTROPY_8BITS[number];
                }

                var entropy = 0.0;
                var n = value.Length;
                var multiplier = 1.0 / (Pow(2, n - 1) - 1);

                for (var k = 0; k <= n - 2; k++)
                {
                    var p = CalculateP(value, k);
                    var round = ((-p * Log(p, 2.0)) + (-(1 - p) * Log(1 - p, 2.0))) * (Pow(2.0, k));

                    if (!double.IsNaN(round))
                        entropy += round;
                }

                return Round(entropy *= multiplier, (int)precision);
            }
            catch (Exception ex)
            {
                //TODO: Handle exception
                var m = ex.Message;
                return double.NaN;
            }
        }
    }
}