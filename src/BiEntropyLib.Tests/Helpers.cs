using System;
using System.Collections.Generic;
using System.Text;

namespace BiEntropyLib.Tests
{
    public static class Helpers
    {
        public static (bool passed, double difference) IsApproximately(double value, double target, double percentDifference = 0.001)
        {
            if (value.Equals(target)) return (true, 0.0);
            var numerator = Math.Abs(value - target);
            var denominator = (value + target) / 2.0;
            var diff = numerator / denominator;

            return diff <= percentDifference ? (true, diff) : (false, diff);
        }
    }
}