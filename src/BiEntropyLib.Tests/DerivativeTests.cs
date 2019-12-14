using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMC.Numerics.BiEntropy;
using System;
using System.Collections;

namespace BiEntropyLib.Tests
{
    [TestClass]
    public class DerivativeTests
    {
        [TestMethod]
        public void FirstBinaryDerivativeTest()
        {
            var arr = new BitArray(new[] { false, true, false, true, false, true, false, true });
            var result = Helpers.BinaryDerivative(arr, 1);
            var value = Helpers.BitArrayToInteger(result);
            Assert.AreEqual(value, 127);
        }

        [TestMethod]
        public void ThirdBinaryDerivativeTest()
        {
            var arr = new BitArray(new[] { false, false, false, true, false, false, false, true });
            var result = Helpers.BinaryDerivative(arr, 3);
            var value = Helpers.BitArrayToInteger(result);
            Assert.AreEqual(value, 31);
        }

        [TestMethod]
        public void SixthBinaryDerivativeTest()
        {
            var arr = new BitArray(new[] { false, false, false, true, true, true, true, true });
            var result = Helpers.BinaryDerivative(arr, 6);
            var value = Helpers.BitArrayToInteger(result);
            Assert.AreEqual(value, 2);
        }

        [TestMethod]
        public void CalculatePTest()
        {
            var p4 = Helpers.CalculateP(new BitArray(new[] { true, false, true, true }),0);
            var p3 = Helpers.CalculateP(new BitArray(new[] { true, true, false }), 0);
            var p2 = Helpers.CalculateP(new BitArray(new[] { false, true }), 0);

            Assert.AreEqual(Math.Round(p4,2), 0.75);
            Assert.AreEqual(Math.Round(p3,2), 0.67);
            Assert.AreEqual(Math.Round(p2,2), 0.50);
        }
    }
}