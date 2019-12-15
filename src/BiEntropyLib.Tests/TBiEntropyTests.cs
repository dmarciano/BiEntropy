using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMC.Numerics.BiEntropy;
using System.Collections;

namespace BiEntropyLib.Tests
{
    [TestClass]
    public class TBiEntropyTests
    {
        [TestMethod]
        public void FourBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { true, false, false, true });
            var value0 = TresBiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var result0 = Helpers.IsApproximately(value0, 0.54);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
        }
    }
}