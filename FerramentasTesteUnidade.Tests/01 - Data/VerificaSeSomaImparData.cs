using System;
using System.Collections;
using System.Collections.Generic;

namespace FerramentasTesteUnidade.Tests.Data
{
    public class VerificaSeSomaImparData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, true };
            yield return new object[] { 3, 4, true };
            yield return new object[] { 5, 6, true };
            yield return new object[] { -4, -6, false };
            yield return new object[] { -2, 2, false };
            yield return new object[] { int.MinValue, int.MaxValue, true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}