using System;
using System.Collections;

namespace SMC.Numerics.BiEntropy
{
    public struct MultiKey
    {
        private readonly int hashCode;
        public readonly BitArray Key1;
        public readonly int Key2;

        public MultiKey(BitArray key1, int key2)
        {
            Key1 = key1;
            Key2 = key2;

            var data = new byte[Key1.Length];
            Key1.CopyTo(data, 0);

            hashCode = 352033288;
            hashCode = hashCode * -1521134295 + BitConverter.ToString(data).GetHashCode();
            hashCode = hashCode * -1521134295 + Key2.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals((MultiKey)obj);
        }

        public bool Equals(MultiKey other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override int GetHashCode() => hashCode;
    }
}