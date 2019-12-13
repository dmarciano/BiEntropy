using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMC.Numerics.BiEntropy;
using System;
using System.Collections;

namespace BiEntropyLib.Tests
{
    [TestClass]
    public class BiEntropyTests
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

            Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0);
            Assert.AreEqual(BiEntropy.Calculate(arr1, false), 1);
            Assert.AreEqual(BiEntropy.Calculate(arr2, false), 1);
            Assert.AreEqual(BiEntropy.Calculate(arr3, false), 0);
        }

        [TestMethod]
        public void FourBitBitArrayWithouConstantTest()
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

            Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0.00);
            Assert.AreEqual(BiEntropy.Calculate(arr1, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr2, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr3, false), 0.41);

            Assert.AreEqual(BiEntropy.Calculate(arr4, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr5, false), 0.14);
            Assert.AreEqual(BiEntropy.Calculate(arr6, false), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr7, false), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr8, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr9, false), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr10, false), 0.14);
            Assert.AreEqual(BiEntropy.Calculate(arr11, false), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr12, false), 0.41);
            Assert.AreEqual(BiEntropy.Calculate(arr13, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr14, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr15, false), 0.00);
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

            Assert.AreEqual(BiEntropy.Calculate(arr0, false), 0.00);
            Assert.AreEqual(BiEntropy.Calculate(arr10, false), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr15, false), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr25, false), 0.93);

            Assert.AreEqual(BiEntropy.Calculate(arr50, false), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr55, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr75, false), 0.11);
            Assert.AreEqual(BiEntropy.Calculate(arr88, false), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr101, false), 0.45);
            Assert.AreEqual(BiEntropy.Calculate(arr156, false), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr175, false), 0.23);
            Assert.AreEqual(BiEntropy.Calculate(arr199, false), 0.95);

            Assert.AreEqual(BiEntropy.Calculate(arr200, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr233, false), 0.95);
            Assert.AreEqual(BiEntropy.Calculate(arr247, false), 0.93);
            Assert.AreEqual(BiEntropy.Calculate(arr255, false), 0.00);
        }
    }
}