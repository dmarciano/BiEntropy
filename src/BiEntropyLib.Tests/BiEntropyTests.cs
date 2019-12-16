using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMC.Numerics.BiEntropy;
using System;
using System.Collections;
using System.Globalization;

namespace BiEntropyLib.Tests
{
    [TestClass]
    public class BiEntropyTests
    {
        [TestMethod]
        public void CharacterConstantTest()
        {
            var value101 = BiEntropy.Calculate('e', useConstantIfAvailable: true);
            var result101 = Helpers.IsApproximately(value101, 0.45);
            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void StringConstantTest()
        {
            var value101 = BiEntropy.Calculate("e", useConstantIfAvailable: true);
            var result101 = Helpers.IsApproximately(value101, 0.45);
            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void TwoBitBitArrayConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false });
            var arr1 = new BitArray(new[] { false, true });
            var arr2 = new BitArray(new[] { true, false });
            var arr3 = new BitArray(new[] { true, true });

            Assert.AreEqual(BiEntropy.Calculate(arr0), 0);
            Assert.AreEqual(BiEntropy.Calculate(arr1), 1);
            Assert.AreEqual(BiEntropy.Calculate(arr2), 1);
            Assert.AreEqual(BiEntropy.Calculate(arr3), 0);
        }

        [TestMethod]
        public void TwoBitArrayCalculatedTest()
        {
            var arr0 = new BitArray(new[] { false, false });
            var arr1 = new BitArray(new[] { false, true });
            var arr2 = new BitArray(new[] { true, false });
            var arr3 = new BitArray(new[] { true, true });

            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value1 = BiEntropy.Calculate(arr1, useConstantIfAvailable: false);
            var value2 = BiEntropy.Calculate(arr2, useConstantIfAvailable: false);
            var value3 = BiEntropy.Calculate(arr3, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0);
            var result1 = Helpers.IsApproximately(value1, 1);
            var result2 = Helpers.IsApproximately(value2, 1);
            var result3 = Helpers.IsApproximately(value3, 0);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result1.passed, $"Percent difference: {result1.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result2.passed, $"Percent difference: {result2.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result3.passed, $"Percent difference: {result3.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void FourBitArrayConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false, false, false });
            var arr1 = new BitArray(new[] { false, false, false, true });
            var arr2 = new BitArray(new[] { false, false, true, false });
            var arr3 = new BitArray(new[] { false, false, true, true });

            var arr4 = new BitArray(new[] { false, true, false, false });
            var arr5 = new BitArray(new[] { false, true, false, true });
            var arr6 = new BitArray(new[] { false, true, true, false });
            var arr7 = new BitArray(new[] { false, true, true, true });

            var arr8 = new BitArray(new[] { true, false, false, false });
            var arr9 = new BitArray(new[] { true, false, false, true });
            var arr10 = new BitArray(new[] { true, false, true, false });
            var arr11 = new BitArray(new[] { true, false, true, true });

            var arr12 = new BitArray(new[] { true, true, false, false });
            var arr13 = new BitArray(new[] { true, true, false, true });
            var arr14 = new BitArray(new[] { true, true, true, false });
            var arr15 = new BitArray(new[] { true, true, true, true });

            Assert.AreEqual(BiEntropy.Calculate(arr0), 0.00);
            Assert.AreEqual(BiEntropy.Calculate(arr1), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr2), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr3), 0.41);

            Assert.AreEqual(BiEntropy.Calculate(arr4), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr5), 0.14);
            Assert.AreEqual(BiEntropy.Calculate(arr6), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr7), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr8), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr9), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr10), 0.14);
            Assert.AreEqual(BiEntropy.Calculate(arr11), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr12), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr13), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr14), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr15), 0.00);
        }

        [TestMethod]
        public void EightBitArrayConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false, false, false, false, false, false, false });
            var arr10 = new BitArray(new[] { false, false, false, false, true, false, true, false });
            var arr15 = new BitArray(new[] { false, false, false, false, true, true, true, true });
            var arr25 = new BitArray(new[] { false, false, false, true, true, false, false, true });

            var arr50 = new BitArray(new[] { false, false, true, true, false, false, true, false });
            var arr55 = new BitArray(new[] { false, false, true, true, false, true, true, true });
            var arr75 = new BitArray(new[] { false, true, false, false, true, false, true, true });
            var arr88 = new BitArray(new[] { false, true, false, true, true, false, false, false });

            var arr101 = new BitArray(new[] { false, true, true, false, false, true, false, true });
            var arr156 = new BitArray(new[] { true, false, false, true, true, true, false, false });
            var arr175 = new BitArray(new[] { true, false, true, false, true, true, true, true });
            var arr199 = new BitArray(new[] { true, true, false, false, false, true, true, true });

            var arr200 = new BitArray(new[] { true, true, false, false, true, false, false, false });
            var arr233 = new BitArray(new[] { true, true, true, false, true, false, false, true });
            var arr247 = new BitArray(new[] { true, true, true, true, false, true, true, true });
            var arr255 = new BitArray(new[] { true, true, true, true, true, true, true, true });

            Assert.AreEqual(BiEntropy.Calculate(arr0), 0.00);
            Assert.AreEqual(BiEntropy.Calculate(arr10), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr15), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr25), 0.93);

            Assert.AreEqual(BiEntropy.Calculate(arr50), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr55), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr75), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr88), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr101), 0.45);
            Assert.AreEqual(BiEntropy.Calculate(arr156), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr175), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr199), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr200), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr233), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr247), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr255), 0.00);
        }

        [TestMethod]
        public void CharacterWithoutConstantTest()
        {
            var value101 = BiEntropy.Calculate('e', useConstantIfAvailable: false);
            var result101 = Helpers.IsApproximately(value101, 0.45);
            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void StringWithoutConstantTest()
        {
            var value101 = BiEntropy.Calculate("e", useConstantIfAvailable: false);
            var result101 = Helpers.IsApproximately(value101, 0.45);
            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void TwoBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false });
            var arr1 = new BitArray(new[] { false, true });
            var arr2 = new BitArray(new[] { true, false });
            var arr3 = new BitArray(new[] { true, true });

            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value1 = BiEntropy.Calculate(arr1, useConstantIfAvailable: false);
            var value2 = BiEntropy.Calculate(arr2, useConstantIfAvailable: false);
            var value3 = BiEntropy.Calculate(arr3, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0);
            var result1 = Helpers.IsApproximately(value1, 1);
            var result2 = Helpers.IsApproximately(value1, 1);
            var result3 = Helpers.IsApproximately(value3, 0);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result1.passed, $"Percent difference: {result1.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result2.passed, $"Percent difference: {result2.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result3.passed, $"Percent difference: {result3.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void FourBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { true, false, true, true });
            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var result0 = Helpers.IsApproximately(value0, 0.95);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void FourBitArrayWithoutConstantTest2()
        {
            var arr0 = new BitArray(new[] { false, false, false, false });
            var arr1 = new BitArray(new[] { false, false, false, true });
            var arr2 = new BitArray(new[] { false, false, true, false });
            var arr3 = new BitArray(new[] { false, false, true, true });

            var arr4 = new BitArray(new[] { false, true, false, false });
            var arr5 = new BitArray(new[] { false, true, false, true });
            var arr6 = new BitArray(new[] { false, true, true, false });
            var arr7 = new BitArray(new[] { false, true, true, true });

            var arr8 = new BitArray(new[] { true, false, false, false });
            var arr9 = new BitArray(new[] { true, false, false, true });
            var arr10 = new BitArray(new[] { true, false, true, false });
            var arr11 = new BitArray(new[] { true, false, true, true });

            var arr12 = new BitArray(new[] { true, true, false, false });
            var arr13 = new BitArray(new[] { true, true, false, true });
            var arr14 = new BitArray(new[] { true, true, true, false });
            var arr15 = new BitArray(new[] { true, true, true, true });

            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value1 = BiEntropy.Calculate(arr1, useConstantIfAvailable: false);
            var value2 = BiEntropy.Calculate(arr2, useConstantIfAvailable: false);
            var value3 = BiEntropy.Calculate(arr3, useConstantIfAvailable: false);

            var value4 = BiEntropy.Calculate(arr4, useConstantIfAvailable: false);
            var value5 = BiEntropy.Calculate(arr5, useConstantIfAvailable: false);
            var value6 = BiEntropy.Calculate(arr6, useConstantIfAvailable: false);
            var value7 = BiEntropy.Calculate(arr7, useConstantIfAvailable: false);

            var value8 = BiEntropy.Calculate(arr8, useConstantIfAvailable: false);
            var value9 = BiEntropy.Calculate(arr9, useConstantIfAvailable: false);
            var value10 = BiEntropy.Calculate(arr10, useConstantIfAvailable: false);
            var value11 = BiEntropy.Calculate(arr11, useConstantIfAvailable: false);

            var value12 = BiEntropy.Calculate(arr12, useConstantIfAvailable: false);
            var value13 = BiEntropy.Calculate(arr13, useConstantIfAvailable: false);
            var value14 = BiEntropy.Calculate(arr14, useConstantIfAvailable: false);
            var value15 = BiEntropy.Calculate(arr15, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result1 = Helpers.IsApproximately(value1, 0.95);
            var result2 = Helpers.IsApproximately(value2, 0.95);
            var result3 = Helpers.IsApproximately(value3, 0.41);

            var result4 = Helpers.IsApproximately(value4, 0.95);
            var result5 = Helpers.IsApproximately(value5, 0.14);
            var result6 = Helpers.IsApproximately(value6, 0.41);
            var result7 = Helpers.IsApproximately(value7, 0.95);

            var result8 = Helpers.IsApproximately(value8, 0.95);
            var result9 = Helpers.IsApproximately(value9, 0.41);
            var result10 = Helpers.IsApproximately(value10, 0.14);
            var result11 = Helpers.IsApproximately(value11, 0.95);

            var result12 = Helpers.IsApproximately(value12, 0.41);
            var result13 = Helpers.IsApproximately(value13, 0.95);
            var result14 = Helpers.IsApproximately(value14, 0.95);
            var result15 = Helpers.IsApproximately(value15, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result1.passed, $"Percent difference: {result1.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result2.passed, $"Percent difference: {result2.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result3.passed, $"Percent difference: {result3.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result4.passed, $"Percent difference: {result4.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result5.passed, $"Percent difference: {result5.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result6.passed, $"Percent difference: {result6.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result7.passed, $"Percent difference: {result7.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result8.passed, $"Percent difference: {result8.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result9.passed, $"Percent difference: {result9.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result10.passed, $"Percent difference: {result10.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result11.passed, $"Percent difference: {result11.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result12.passed, $"Percent difference: {result12.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result13.passed, $"Percent difference: {result13.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result14.passed, $"Percent difference: {result14.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void EightBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false, false, false, false, false, false, false });
            var arr10 = new BitArray(new[] { false, false, false, false, true, false, true, false });
            var arr15 = new BitArray(new[] { false, false, false, false, true, true, true, true });
            var arr25 = new BitArray(new[] { false, false, false, true, true, false, false, true });

            var arr50 = new BitArray(new[] { false, false, true, true, false, false, true, false });
            var arr55 = new BitArray(new[] { false, false, true, true, false, true, true, true });
            var arr75 = new BitArray(new[] { false, true, false, false, true, false, true, true });
            var arr88 = new BitArray(new[] { false, true, false, true, true, false, false, false });

            var arr101 = new BitArray(new[] { false, true, true, false, false, true, false, true });
            var arr156 = new BitArray(new[] { true, false, false, true, true, true, false, false });
            var arr175 = new BitArray(new[] { true, false, true, false, true, true, true, true });
            var arr199 = new BitArray(new[] { true, true, false, false, false, true, true, true });

            var arr200 = new BitArray(new[] { true, true, false, false, true, false, false, false });
            var arr233 = new BitArray(new[] { true, true, true, false, true, false, false, true });
            var arr247 = new BitArray(new[] { true, true, true, true, false, true, true, true });
            var arr255 = new BitArray(new[] { true, true, true, true, true, true, true, true });

            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value10 = BiEntropy.Calculate(arr10, useConstantIfAvailable: false);
            var value15 = BiEntropy.Calculate(arr15, useConstantIfAvailable: false);
            var value25 = BiEntropy.Calculate(arr25, useConstantIfAvailable: false);

            var value50 = BiEntropy.Calculate(arr50, useConstantIfAvailable: false);
            var value55 = BiEntropy.Calculate(arr55, useConstantIfAvailable: false);
            var value75 = BiEntropy.Calculate(arr75, useConstantIfAvailable: false);
            var value88 = BiEntropy.Calculate(arr88, useConstantIfAvailable: false);

            var value101 = BiEntropy.Calculate(arr101, useConstantIfAvailable: false);
            var value156 = BiEntropy.Calculate(arr156, useConstantIfAvailable: false);
            var value175 = BiEntropy.Calculate(arr175, useConstantIfAvailable: false);
            var value199 = BiEntropy.Calculate(arr199, useConstantIfAvailable: false);

            var value200 = BiEntropy.Calculate(arr200, useConstantIfAvailable: false);
            var value233 = BiEntropy.Calculate(arr233, useConstantIfAvailable: false);
            var value247 = BiEntropy.Calculate(arr247, useConstantIfAvailable: false);
            var value255 = BiEntropy.Calculate(arr255, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result10 = Helpers.IsApproximately(value10, 0.23);
            var result15 = Helpers.IsApproximately(value15, 0.11);
            var result25 = Helpers.IsApproximately(value25, 0.93);

            var result50 = Helpers.IsApproximately(value50, 0.93);
            var result55 = Helpers.IsApproximately(value55, 0.95);
            var result75 = Helpers.IsApproximately(value75, 0.11);
            var result88 = Helpers.IsApproximately(value88, 0.95);

            var result101 = Helpers.IsApproximately(value101, 0.45);
            var result156 = Helpers.IsApproximately(value156, 0.23);
            var result175 = Helpers.IsApproximately(value175, 0.23);
            var result199 = Helpers.IsApproximately(value199, 0.95);

            var result200 = Helpers.IsApproximately(value200, 0.95);
            var result233 = Helpers.IsApproximately(value233, 0.95);
            var result247 = Helpers.IsApproximately(value247, 0.93);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result10.passed, $"Percent difference: {result10.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result50.passed, $"Percent difference: {result50.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result55.passed, $"Percent difference: {result55.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result75.passed, $"Percent difference: {result75.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result88.passed, $"Percent difference: {result88.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result156.passed, $"Percent difference: {result156.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result199.passed, $"Percent difference: {result199.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result200.passed, $"Percent difference: {result200.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result233.passed, $"Percent difference: {result233.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void ByteConstantTest()
        {
            var arr0 = (byte)0x00;
            var arr10 = (byte)0x0A;
            var arr15 = (byte)0x0F;
            var arr25 = (byte)0x19;

            var arr50 = (byte)0x32;
            var arr55 = (byte)0x37;
            var arr75 = (byte)0x4B;
            var arr88 = (byte)0x58;

            var arr101 = (byte)0x65;
            var arr156 = (byte)0x9C;
            var arr175 = (byte)0xAF;
            var arr199 = (byte)0xC7;

            var arr200 = (byte)0xC8;
            var arr233 = (byte)0xE9;
            var arr247 = (byte)0xF7;
            var arr255 = (byte)0xFF;

            Assert.AreEqual(BiEntropy.Calculate(arr0), 0.00);
            Assert.AreEqual(BiEntropy.Calculate(arr10), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr15), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr25), 0.93);

            Assert.AreEqual(BiEntropy.Calculate(arr50), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr55), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr75), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr88), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr101), 0.45);
            Assert.AreEqual(BiEntropy.Calculate(arr156), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr175), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr199), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr200), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr233), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr247), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr255), 0.00);
        }

        [TestMethod]
        public void ByteWithoutConstantTest()
        {
            var arr0 = (byte)0x00;
            var arr10 = (byte)0x0A;
            var arr15 = (byte)0x0F;
            var arr25 = (byte)0x19;

            var arr50 = (byte)0x32;
            var arr55 = (byte)0x37;
            var arr75 = (byte)0x4B;
            var arr88 = (byte)0x58;

            var arr101 = (byte)0x65;
            var arr156 = (byte)0x9C;
            var arr175 = (byte)0xAF;
            var arr199 = (byte)0xC7;

            var arr200 = (byte)0xC8;
            var arr233 = (byte)0xE9;
            var arr247 = (byte)0xF7;
            var arr255 = (byte)0xFF;

            var value0 = BiEntropy.Calculate(arr0, useConstantIfAvailable: false);
            var value10 = BiEntropy.Calculate(arr10, useConstantIfAvailable: false);
            var value15 = BiEntropy.Calculate(arr15, useConstantIfAvailable: false);
            var value25 = BiEntropy.Calculate(arr25, useConstantIfAvailable: false);

            var value50 = BiEntropy.Calculate(arr50, useConstantIfAvailable: false);
            var value55 = BiEntropy.Calculate(arr55, useConstantIfAvailable: false);
            var value75 = BiEntropy.Calculate(arr75, useConstantIfAvailable: false);
            var value88 = BiEntropy.Calculate(arr88, useConstantIfAvailable: false);

            var value101 = BiEntropy.Calculate(arr101, useConstantIfAvailable: false);
            var value156 = BiEntropy.Calculate(arr156, useConstantIfAvailable: false);
            var value175 = BiEntropy.Calculate(arr175, useConstantIfAvailable: false);
            var value199 = BiEntropy.Calculate(arr199, useConstantIfAvailable: false);

            var value200 = BiEntropy.Calculate(arr200, useConstantIfAvailable: false);
            var value233 = BiEntropy.Calculate(arr233, useConstantIfAvailable: false);
            var value247 = BiEntropy.Calculate(arr247, useConstantIfAvailable: false);
            var value255 = BiEntropy.Calculate(arr255, useConstantIfAvailable: false);

            var result0 = Helpers.IsApproximately(value0, 0.00);
            var result10 = Helpers.IsApproximately(value10, 0.23);
            var result15 = Helpers.IsApproximately(value15, 0.11);
            var result25 = Helpers.IsApproximately(value25, 0.93);

            var result50 = Helpers.IsApproximately(value50, 0.93);
            var result55 = Helpers.IsApproximately(value55, 0.95);
            var result75 = Helpers.IsApproximately(value75, 0.11);
            var result88 = Helpers.IsApproximately(value88, 0.95);

            var result101 = Helpers.IsApproximately(value101, 0.45);
            var result156 = Helpers.IsApproximately(value156, 0.23);
            var result175 = Helpers.IsApproximately(value175, 0.23);
            var result199 = Helpers.IsApproximately(value199, 0.95);

            var result200 = Helpers.IsApproximately(value200, 0.95);
            var result233 = Helpers.IsApproximately(value233, 0.95);
            var result247 = Helpers.IsApproximately(value247, 0.93);
            var result255 = Helpers.IsApproximately(value255, 0.00);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result10.passed, $"Percent difference: {result10.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result15.passed, $"Percent difference: {result15.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result25.passed, $"Percent difference: {result25.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result50.passed, $"Percent difference: {result50.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result55.passed, $"Percent difference: {result55.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result75.passed, $"Percent difference: {result75.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result88.passed, $"Percent difference: {result88.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result101.passed, $"Percent difference: {result101.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result156.passed, $"Percent difference: {result156.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result175.passed, $"Percent difference: {result175.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result199.passed, $"Percent difference: {result199.difference.ToString("0.#####")} which is greater than 0.001.");

            Assert.IsTrue(result200.passed, $"Percent difference: {result200.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result233.passed, $"Percent difference: {result233.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result247.passed, $"Percent difference: {result247.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result255.passed, $"Percent difference: {result255.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void CacheTest()
        {
            BiEntropy.EnableCache();
            var val1 = BiEntropy.Calculate("e", useConstantIfAvailable: false);
            var res1 = Helpers.IsApproximately(val1, 0.45);
            Assert.IsTrue(res1.passed, $"Percent difference: {res1.difference.ToString("0.#####")} which is greater than 0.001.");

            var val2 = BiEntropy.Calculate("e", useConstantIfAvailable: false);
            var res2 = Helpers.IsApproximately(val1, 0.45);
            Assert.IsTrue(res2.passed, $"Percent difference: {res2.difference.ToString("0.#####")} which is greater than 0.001.");
        }
    }
}