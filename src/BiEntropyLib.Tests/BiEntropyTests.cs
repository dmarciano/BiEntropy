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
            var result2 = Helpers.IsApproximately(value2, 2);
            var result3 = Helpers.IsApproximately(value3, 3);

            Assert.IsTrue(result0.passed, $"Percent difference: {result0.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result1.passed, $"Percent difference: {result1.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result2.passed, $"Percent difference: {result2.difference.ToString("0.#####")} which is greater than 0.001.");
            Assert.IsTrue(result3.passed, $"Percent difference: {result3.difference.ToString("0.#####")} which is greater than 0.001.");
        }

        [TestMethod]
        public void FourBitBitArrayConstantTest()
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
        public void EightBitBitArrayConstantTest()
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
        public void TwoBitBitArrayWithoutConstantTest()
        {
            var arr0 = new BitArray(new[] { false, false });
            var arr1 = new BitArray(new[] { false, true });
            var arr2 = new BitArray(new[] { true, false });
            var arr3 = new BitArray(new[] { true, true });

            //Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0);
            //Assert.AreEqual(BiEntropy.Calculate(arr1, false), 1);
            //Assert.AreEqual(BiEntropy.Calculate(arr2, false), 1);
            //Assert.AreEqual(BiEntropy.Calculate(arr3, false), 0);
        }

        [TestMethod]
        public void FourBitBitArrayWithoutConstantTest()
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

            //Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0.00);
            //Assert.AreEqual(BiEntropy.Calculate(arr1, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr2, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr3, false), 0.41);

            //Assert.AreEqual(BiEntropy.Calculate(arr4, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr5, false), 0.14);
            //Assert.AreEqual(BiEntropy.Calculate(arr6, false), 0.41);
            //Assert.AreEqual(BiEntropy.Calculate(arr7, false), 0.95);

            //Assert.AreEqual(BiEntropy.Calculate(arr8, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr9, false), 0.41);
            //Assert.AreEqual(BiEntropy.Calculate(arr10, false), 0.14);
            //Assert.AreEqual(BiEntropy.Calculate(arr11, false), 0.95);

            //Assert.AreEqual(BiEntropy.Calculate(arr12, false), 0.41);
            //Assert.AreEqual(BiEntropy.Calculate(arr13, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr14, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr15, false), 0.00);
        }

        [TestMethod]
        public void EightBitBitArrayWithoutConstantTest()
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

            //Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0.00);
            //Assert.AreEqual(BiEntropy.Calculate(arr10, false), 0.23);
            //Assert.AreEqual(BiEntropy.Calculate(arr15, false), 0.11);
            //Assert.AreEqual(BiEntropy.Calculate(arr25, false), 0.93);

            //Assert.AreEqual(BiEntropy.Calculate(arr50, false), 0.93);
            //Assert.AreEqual(BiEntropy.Calculate(arr55, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr75, false), 0.11);
            //Assert.AreEqual(BiEntropy.Calculate(arr88, false), 0.95);

            //Assert.AreEqual(BiEntropy.Calculate(arr101, false), 0.45);
            //Assert.AreEqual(BiEntropy.Calculate(arr156, false), 0.23);
            //Assert.AreEqual(BiEntropy.Calculate(arr175, false), 0.23);
            //Assert.AreEqual(BiEntropy.Calculate(arr199, false), 0.95);

            //Assert.AreEqual(BiEntropy.Calculate(arr200, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr233, false), 0.95);
            //Assert.AreEqual(BiEntropy.Calculate(arr247, false), 0.93);
            //Assert.AreEqual(BiEntropy.Calculate(arr255, false), 0.00);
        }
    }
}