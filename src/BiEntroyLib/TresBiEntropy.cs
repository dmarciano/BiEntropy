using System;
using System.Collections;
using System.Text;
using static SMC.Numerics.BiEntropy.Helpers;
using static System.Math;

namespace SMC.Numerics.BiEntropy
{
    public static class TresBiEntropy
    {
        public static double Calculate(sbyte value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(byte value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(new byte[] { value }), precision, useConstantIfAvailable);
        }

        public static double Calculate(short value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(ushort value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(int value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(uint value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(long value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(ulong value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(float value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(double value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(BitConverter.GetBytes(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(decimal value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(decimal.GetBits(value)), precision, useConstantIfAvailable);
        }

        public static double Calculate(char value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(value, Encoding.UTF8, precision, useConstantIfAvailable);
        }

        public static double Calculate(char value, Encoding encoding, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(encoding.GetBytes(new char[] { value })), precision, useConstantIfAvailable);
        }

        public static double Calculate(string value, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(value, Encoding.UTF8, precision, useConstantIfAvailable);
        }

        public static double Calculate(string value, Encoding encoding, uint precision = 2, bool useConstantIfAvailable = true)
        {
            return Calculate(new BitArray(encoding.GetBytes(value)), precision, useConstantIfAvailable);
        }

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
                    multiplerSum += Log(k + 2, 2);
                var multiplier = 1.0 / multiplerSum;


                for(var k = 0; k<= n-2; k++)
                {
                    var p = CalculateP(value, k);
                    var round = ((-p * Log(p, 2.0)) + (-(1-p) * Log(1-p, 2.0))) * Log(k + 2, 2.0);

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