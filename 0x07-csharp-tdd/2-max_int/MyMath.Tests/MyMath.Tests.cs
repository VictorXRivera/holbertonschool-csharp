using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void empty_list()
        {
            List<int> _empty = new List<int>();
            int result = MyMath.Operations.Max(_empty);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void max_int()
        {
            List<int> test_list = new List<int>() {5, 10, 15, 20, 25, 30};
            int result = MyMath.Operations.Max(test_list);
            Assert.AreEqual(result, 30);
        }

        [Test]
        public void negative_max_int()
        {
            List<int> test_list = new List<int>() {-1, 1, -2, 2, -3, 3};
            int result = MyMath.Operations.Max(test_list);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void null_list()
        {
            List<int> _empty = null;
            int result = MyMath.Operations.Max(_empty);
            Assert.AreEqual(0, result);
        }
    }
}