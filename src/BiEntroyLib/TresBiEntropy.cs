using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMC.Numerics.BiEntropy.Helpers;

namespace SMC.Numerics.BiEntropy
{
    public static class TresBiEntropy
    {
        public static double Calculate(BitArray value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            try
            {

                if (value.Length == 2)
                    return Constants.BIENTROPY_2BITS[BitArrayToInteger(value)];

                if(useConstantIfAvailable && (value.Length==4 || value.Length == 8))
                {
                    var number = BitArrayToInteger(value);
                    if (value.Length == 4)
                        return Constants.BIENTROPY_4BITS[number];
                    else
                        return Constants.TBIENTROPY_8BITS[number];
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