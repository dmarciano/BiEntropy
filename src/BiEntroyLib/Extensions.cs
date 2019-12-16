using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMC;

namespace SMC.Numerics.BiEntropy
{
    public static class Extensions
    {
        #region BiEntropy

        #region BitArray
        public static double BiEntropy(this BitArray value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this BitArray value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this BitArray value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this BitArray value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }
        #endregion

        #region Integral
        public static double BiEntropy(this sbyte value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this sbyte value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this sbyte value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this sbyte value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this byte value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this byte value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this byte value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this byte value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this short value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this short value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this short value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this short value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this ushort value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this ushort value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this ushort value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this ushort value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this int value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this int value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this int value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this int value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this uint value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this uint value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this uint value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this uint value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this long value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this long value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this long value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this long value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this ulong value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this ulong value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this ulong value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this ulong value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this float value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this float value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this float value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this float value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double BiEntropy(this double value)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value);
        }

        public static double BiEntropy(this double value, uint precision)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision);
        }

        public static double BiEntropy(this double value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double BiEntropy(this double value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.BiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }
        #endregion

        #endregion

        #region TresBiEntropy

        #region BitArray
        public static double TresBiEntropy(this BitArray value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this BitArray value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this BitArray value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this BitArray value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }
        #endregion

        #region Integral
        public static double TresBiEntropy(this sbyte value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this sbyte value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this sbyte value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this sbyte value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this byte value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this byte value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this byte value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this byte value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this short value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this short value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this short value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this short value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this ushort value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this ushort value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this ushort value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this ushort value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this int value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this int value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this int value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this int value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this uint value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this uint value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this uint value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this uint value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this long value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this long value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this long value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this long value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this ulong value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this ulong value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this ulong value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this ulong value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this float value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this float value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this float value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this float value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }

        public static double TresBiEntropy(this double value)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value);
        }

        public static double TresBiEntropy(this double value, uint precision)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision);
        }

        public static double TresBiEntropy(this double value, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, useConstantIfAvailable: useConstantIfAvailable);
        }

        public static double TresBiEntropy(this double value, uint precision, bool useConstantIfAvailable)
        {
            return Numerics.BiEntropy.TresBiEntropy.Calculate(value, precision, useConstantIfAvailable);
        }
        #endregion

        #endregion
    }
}