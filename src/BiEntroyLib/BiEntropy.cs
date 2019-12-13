using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC.Numerics.BiEntropy
{
    public static class BiEntropy
    {
        public static double Calculate(BitArray value, bool useConstantIfAvailable = true)
        {
            try
            {
                if(useConstantIfAvailable && (value.Length == 2 || value.Length == 4 || value.Length == 8))
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