using System;
using System.Collections;

namespace SMC.Numerics.BiEntropy
{
    public static class BiEntropy
    {
        public static double Calculate(BitArray value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            try
            {
                if (value.Length > 32) return TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);

                if (useConstantIfAvailable && (value.Length == 2 || value.Length == 4 || value.Length == 8))
                {
                    var number = Helpers.BitArrayToInteger(value);
                    switch (value.Length)
                    {
                        case 2:
                            return Constants.BIENTROPY_2BITS[number];
                        case 4:
                            return Constants.BIENTROPY_4BITS[number];
                        default:
                            return Constants.BIENTROPY_8BITS[number];
                    }
                }

                var entropy = 0.0;
                var n = value.Length;
                var multiplier = 1.0 / (2 ^ (n - 1) - 1);
                

                return entropy;
            }
            catch (Exception ex)
            {
                //TODO: Handle exception
                var m = ex.Message;
                return double.NaN;
            }
        }
    }

    public static class TresBiEntropy
    {
        public static double Calculate(BitArray value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            try
            {
                if (useConstantIfAvailable && (value.Length == 2 || value.Length == 4 || value.Length == 8))
                {
                    var number = Helpers.BitArrayToInteger(value);
                    switch (value.Length)
                    {
                        case 2:
                            return Constants.BIENTROPY_2BITS[number];
                        case 4:
                            return Constants.BIENTROPY_4BITS[number];
                        default:
                            return Constants.BIENTROPY_8BITS[number];
                    }
                }

                var entropy = 0.0;
                var n = value.Length;

                var multiplerSum = 0.0;
                for (var k = 0; k <= n - 2; k++)
                    multiplerSum += Math.Log(k + 2, 2);
                var multiplier = 1.0 / multiplerSum;

                

                return entropy;
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