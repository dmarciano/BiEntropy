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

        [TestMethod]
        public void EightBitArrayConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false, false, false, false, false, false, false });
            var arr5 = new BitArray(new[] { false, false, false, false, false, true, false, true });
            var arr15 = new BitArray(new[] { false, false, false, false, true, true, true, true });
            var arr25 = new BitArray(new[] { false, false, false, true, true, false, false, true });

            var arr53 = new BitArray(new[] { false, false, true, true, false, true, false, true });
            var arr71 = new BitArray(new[] { false, true, false, false, false, true, true, true });
            var arr92 = new BitArray(new[] { false, true, false, true, true, true, false, false });
            var arr99 = new BitArray(new[] { false, true, true, false, false, false, true, true });

            var arr101 = new BitArray(new[] { false, true, true, false, false, true, false, true });
            var arr132 = new BitArray(new[] { true, false, false, false, false, true, false, false });
            var arr175 = new BitArray(new[] { true, false, true, false, true, true, true, true });
            var arr187 = new BitArray(new[] { true, false, true, true, true, false, true, true });

            var arr202 = new BitArray(new[] { true, true, false, false, true, false, true, false });
            var arr226 = new BitArray(new[] { true, true, true, false, false, false, true, false });
            var arr247 = new BitArray(new[] { true, true, true, true, false, true, true, true });
            var arr255 = new BitArray(new[] { true, true, true, true, true, true, true, true });

            var value0 = TresBiEntropy.Calculate(arr0, useConstantIfAvailable: true);
            var value5 = TresBiEntropy.Calculate(arr5, useConstantIfAvailable: true);
            var value15 = TresBiEntropy.Calculate(arr15, useConstantIfAvailable: true);
            var value25 = TresBiEntropy.Calculate(arr25, useConstantIfAvailable: true);

            var value53 = TresBiEntropy.Calculate(arr53, useConstantIfAvailable: true);
            var value71 = TresBiEntropy.Calculate(arr71, useConstantIfAvailable: true);
            var value92 = TresBiEntropy.Calculate(arr92, useConstantIfAvailable: true);
            var value99 = TresBiEntropy.Calculate(arr99, useConstantIfAvailable: true);

            var value101 = TresBiEntropy.Calculate(arr101, useConstantIfAvailable: true);
            var value132 = TresBiEntropy.Calculate(arr132, useConstantIfAvailable: true);
            var value175 = TresBiEntropy.Calculate(arr175, useConstantIfAvailable: true);
            var value187 = TresBiEntropy.Calculate(arr187, useConstantIfAvailable: true);

            var value202 = TresBiEntropy.Calculate(arr202, useConstantIfAvailable: true);
            var value226 = TresBiEntropy.Calculate(arr226, useConstantIfAvailable: true);
            var value247 = TresBiEntropy.Calculate(arr247, useConstantIfAvailable: true);
            var value255 = TresBiEntropy.Calculate(arr255, useConstantIfAvailable: true);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result5 = Helpers.IsApproximately(value5, 0.56);
            var result15 = Helpers.IsApproximately(value15, 0.39);
            var result25 = Helpers.IsApproximately(value25, 0.86);

            var result53 = Helpers.IsApproximately(value53, 0.73);
            var result71 = Helpers.IsApproximately(value71, 0.75);
            var result92 = Helpers.IsApproximately(value92, 0.78);
            var result99 = Helpers.IsApproximately(value99, 0.57);

            var result101 = Helpers.IsApproximately(value101, 0.72);
            var result132 = Helpers.IsApproximately(value132, 0.73);
            var result175 = Helpers.IsApproximately(value175, 0.56);
            var result187 = Helpers.IsApproximately(value187, 0.29);

            var result202 = Helpers.IsApproximately(value202, 0.73);
            var result226 = Helpers.IsApproximately(value226, 0.75);
            var result247 = Helpers.IsApproximately(value247, 0.86);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result5.passed, $"Percent difference: {result5.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result53.passed, $"Percent difference: {result53.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result71.passed, $"Percent difference: {result71.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result92.passed, $"Percent difference: {result92.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result99.passed, $"Percent difference: {result99.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result132.passed, $"Percent difference: {result132.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result187.passed, $"Percent difference: {result187.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result202.passed, $"Percent difference: {result202.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result226.passed, $"Percent difference: {result226.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void EightBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false, false, false, false, false, false, false });
            var arr5 = new BitArray(new[] { false, false, false, false, false, true, false, true });
            var arr15 = new BitArray(new[] { false, false, false, false, true, true, true, true });
            var arr25 = new BitArray(new[] { false, false, false, true, true, false, false, true });

            var arr53 = new BitArray(new[] { false, false, true, true, false, true, false, true });
            var arr71 = new BitArray(new[] { false, true, false, false, false, true, true, true });
            var arr92 = new BitArray(new[] { false, true, false, true, true, true, false, false });
            var arr99 = new BitArray(new[] { false, true, true, false, false, false, true, true });

            var arr101 = new BitArray(new[] { false, true, true, false, false, true, false, true });
            var arr132 = new BitArray(new[] { true, false, false, false, false, true, false, false });
            var arr175 = new BitArray(new[] { true, false, true, false, true, true, true, true });
            var arr187 = new BitArray(new[] { true, false, true, true, true, false, true, true });

            var arr202 = new BitArray(new[] { true, true, false, false, true, false, true, false });
            var arr226 = new BitArray(new[] { true, true, true, false, false, false, true, false });
            var arr247 = new BitArray(new[] { true, true, true, true, false, true, true, true });
            var arr255 = new BitArray(new[] { true, true, true, true, true, true, true, true });

            var value0 = TresBiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value5 = TresBiEntropy.Calculate(arr5, useConstantIfAvailable: false);
            var value15 = TresBiEntropy.Calculate(arr15, useConstantIfAvailable: false);
            var value25 = TresBiEntropy.Calculate(arr25, useConstantIfAvailable: false);

            var value53 = TresBiEntropy.Calculate(arr53, useConstantIfAvailable: false);
            var value71 = TresBiEntropy.Calculate(arr71, useConstantIfAvailable: false);
            var value92 = TresBiEntropy.Calculate(arr92, useConstantIfAvailable: false);
            var value99 = TresBiEntropy.Calculate(arr99, useConstantIfAvailable: false);

            var value101 = TresBiEntropy.Calculate(arr101, useConstantIfAvailable: false);
            var value132 = TresBiEntropy.Calculate(arr132, useConstantIfAvailable: false);
            var value175 = TresBiEntropy.Calculate(arr175, useConstantIfAvailable: false);
            var value187 = TresBiEntropy.Calculate(arr187, useConstantIfAvailable: false);

            var value202 = TresBiEntropy.Calculate(arr202, useConstantIfAvailable: false);
            var value226 = TresBiEntropy.Calculate(arr226, useConstantIfAvailable: false);
            var value247 = TresBiEntropy.Calculate(arr247, useConstantIfAvailable: false);
            var value255 = TresBiEntropy.Calculate(arr255, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result5 = Helpers.IsApproximately(value5, 0.56);
            var result15 = Helpers.IsApproximately(value15, 0.39);
            var result25 = Helpers.IsApproximately(value25, 0.86);

            var result53 = Helpers.IsApproximately(value53, 0.73);
            var result71 = Helpers.IsApproximately(value71, 0.75);
            var result92 = Helpers.IsApproximately(value92, 0.78);
            var result99 = Helpers.IsApproximately(value99, 0.57);

            var result101 = Helpers.IsApproximately(value101, 0.72);
            var result132 = Helpers.IsApproximately(value132, 0.73);
            var result175 = Helpers.IsApproximately(value175, 0.56);
            var result187 = Helpers.IsApproximately(value187, 0.29);

            var result202 = Helpers.IsApproximately(value202, 0.73);
            var result226 = Helpers.IsApproximately(value226, 0.75);
            var result247 = Helpers.IsApproximately(value247, 0.86);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result5.passed, $"Percent difference: {result5.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result53.passed, $"Percent difference: {result53.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result71.passed, $"Percent difference: {result71.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result92.passed, $"Percent difference: {result92.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result99.passed, $"Percent difference: {result99.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result132.passed, $"Percent difference: {result132.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result187.passed, $"Percent difference: {result187.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result202.passed, $"Percent difference: {result202.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result226.passed, $"Percent difference: {result226.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void ByteConstantTest()
        {
            var arr0 = (byte)0x00;
            var arr5 = (byte)0x05;
            var arr15 = (byte)0x0F;
            var arr25 = (byte)0x19;

            var arr53 = (byte)0x35;
            var arr71 = (byte)0x47;
            var arr92 = (byte)0x5C;
            var arr99 = (byte)0x63;

            var arr101 = (byte)0x65;
            var arr132 = (byte)0x84;
            var arr175 = (byte)0xAF;
            var arr187 = (byte)0xBB;

            var arr202 = (byte)0xCA;
            var arr226 = (byte)0xE2;
            var arr247 = (byte)0xF7;
            var arr255 = (byte)0xFF;

            var value0 = TresBiEntropy.Calculate(arr0, useConstantIfAvailable: true);
            var value5 = TresBiEntropy.Calculate(arr5, useConstantIfAvailable: true);
            var value15 = TresBiEntropy.Calculate(arr15, useConstantIfAvailable: true);
            var value25 = TresBiEntropy.Calculate(arr25, useConstantIfAvailable: true);

            var value53 = TresBiEntropy.Calculate(arr53, useConstantIfAvailable: true);
            var value71 = TresBiEntropy.Calculate(arr71, useConstantIfAvailable: true);
            var value92 = TresBiEntropy.Calculate(arr92, useConstantIfAvailable: true);
            var value99 = TresBiEntropy.Calculate(arr99, useConstantIfAvailable: true);

            var value101 = TresBiEntropy.Calculate(arr101, useConstantIfAvailable: true);
            var value132 = TresBiEntropy.Calculate(arr132, useConstantIfAvailable: true);
            var value175 = TresBiEntropy.Calculate(arr175, useConstantIfAvailable: true);
            var value187 = TresBiEntropy.Calculate(arr187, useConstantIfAvailable: true);

            var value202 = TresBiEntropy.Calculate(arr202, useConstantIfAvailable: true);
            var value226 = TresBiEntropy.Calculate(arr226, useConstantIfAvailable: true);
            var value247 = TresBiEntropy.Calculate(arr247, useConstantIfAvailable: true);
            var value255 = TresBiEntropy.Calculate(arr255, useConstantIfAvailable: true);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result5 = Helpers.IsApproximately(value5, 0.56);
            var result15 = Helpers.IsApproximately(value15, 0.39);
            var result25 = Helpers.IsApproximately(value25, 0.86);

            var result53 = Helpers.IsApproximately(value53, 0.73);
            var result71 = Helpers.IsApproximately(value71, 0.75);
            var result92 = Helpers.IsApproximately(value92, 0.78);
            var result99 = Helpers.IsApproximately(value99, 0.57);

            var result101 = Helpers.IsApproximately(value101, 0.72);
            var result132 = Helpers.IsApproximately(value132, 0.73);
            var result175 = Helpers.IsApproximately(value175, 0.56);
            var result187 = Helpers.IsApproximately(value187, 0.29);

            var result202 = Helpers.IsApproximately(value202, 0.73);
            var result226 = Helpers.IsApproximately(value226, 0.75);
            var result247 = Helpers.IsApproximately(value247, 0.86);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result5.passed, $"Percent difference: {result5.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result53.passed, $"Percent difference: {result53.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result71.passed, $"Percent difference: {result71.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result92.passed, $"Percent difference: {result92.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result99.passed, $"Percent difference: {result99.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result132.passed, $"Percent difference: {result132.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result187.passed, $"Percent difference: {result187.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result202.passed, $"Percent difference: {result202.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result226.passed, $"Percent difference: {result226.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void ByteWithoutConstantTest()
        {
            var arr0 = (byte)0x00;
            var arr5  = (byte)0x05;
            var arr15 = (byte)0x0F;
            var arr25 = (byte)0x19;

            var arr53 = (byte)0x35;
            var arr71 = (byte)0x47;
            var arr92 = (byte)0x5C;
            var arr99 = (byte)0x63;

            var arr101 = (byte)0x65;
            var arr132 = (byte)0x84;
            var arr175 = (byte)0xAF;
            var arr187 = (byte)0xBB;

            var arr202 = (byte)0xCA;
            var arr226 = (byte)0xE2;
            var arr247 = (byte)0xF7;
            var arr255 = (byte)0xFF;

            var value0 = TresBiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value5 = TresBiEntropy.Calculate(arr5, useConstantIfAvailable: false);
            var value15 = TresBiEntropy.Calculate(arr15, useConstantIfAvailable: false);
            var value25 = TresBiEntropy.Calculate(arr25, useConstantIfAvailable: false);

            var value53 = TresBiEntropy.Calculate(arr53, useConstantIfAvailable: false);
            var value71 = TresBiEntropy.Calculate(arr71, useConstantIfAvailable: false);
            var value92 = TresBiEntropy.Calculate(arr92, useConstantIfAvailable: false);
            var value99 = TresBiEntropy.Calculate(arr99, useConstantIfAvailable: false);

            var value101 = TresBiEntropy.Calculate(arr101, useConstantIfAvailable: false);
            var value132 = TresBiEntropy.Calculate(arr132, useConstantIfAvailable: false);
            var value175 = TresBiEntropy.Calculate(arr175, useConstantIfAvailable: false);
            var value187 = TresBiEntropy.Calculate(arr187, useConstantIfAvailable: false);

            var value202 = TresBiEntropy.Calculate(arr202, useConstantIfAvailable: false);
            var value226 = TresBiEntropy.Calculate(arr226, useConstantIfAvailable: false);
            var value247 = TresBiEntropy.Calculate(arr247, useConstantIfAvailable: false);
            var value255 = TresBiEntropy.Calculate(arr255, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result5 = Helpers.IsApproximately(value5, 0.56);
            var result15 = Helpers.IsApproximately(value15, 0.39);
            var result25 = Helpers.IsApproximately(value25, 0.86);

            var result53 = Helpers.IsApproximately(value53, 0.73);
            var result71 = Helpers.IsApproximately(value71, 0.75);
            var result92 = Helpers.IsApproximately(value92, 0.78);
            var result99 = Helpers.IsApproximately(value99, 0.57);

            var result101 = Helpers.IsApproximately(value101, 0.72);
            var result132 = Helpers.IsApproximately(value132, 0.73);
            var result175 = Helpers.IsApproximately(value175, 0.56);
            var result187 = Helpers.IsApproximately(value187, 0.29);

            var result202 = Helpers.IsApproximately(value202, 0.73);
            var result226 = Helpers.IsApproximately(value226, 0.75);
            var result247 = Helpers.IsApproximately(value247, 0.86);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result5.passed, $"Percent difference: {result5.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result53.passed, $"Percent difference: {result53.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result71.passed, $"Percent difference: {result71.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result92.passed, $"Percent difference: {result92.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result99.passed, $"Percent difference: {result99.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result132.passed, $"Percent difference: {result132.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result187.passed, $"Percent difference: {result187.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result202.passed, $"Percent difference: {result202.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result226.passed, $"Percent difference: {result226.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }
    }
}