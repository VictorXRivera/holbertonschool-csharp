using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void max_is_0()
        {
            List<int> _empty = new List<int>();
            int result = MyMath.Operations.Max(_empty);
            Assert.AreEqual(0, result);
        }
    }
}