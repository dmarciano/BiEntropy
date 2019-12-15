using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMC.Numerics.BiEntropy.BiEntropy;

namespace SMC.Numerics.BiEntropy
{
    public static class Extensions
    {
        public static double BiEntropy(this BitArray value)
        {
            return Calculate(value);
        }

        public static double BiEntropy(this BitArray value, uint precision)
        {
            return Calculate(value, precision);
        }

        public static double BiEntropy(this BitArray value, bool useConstantIfAvailable)
        {
            return Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this BitArray value, uint precision, bool useConstantIfAvailable)
        {
            return Calculate(value, precision, useConstantIfAvailable);
        }
    }
}