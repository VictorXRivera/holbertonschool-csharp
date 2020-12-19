using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(2, 5, ExpectedResult = 7)]
        [TestCase(-1, 2, ExpectedResult = 1)]
        public int _Add(int a, int b)
        {
            return MyMath.Operations.Add(a, b);
        }

        public void Add_Test_0()
        {
            Assert.That(MyMath.Operations.Add(5, 5), Is.EqualTo(4));
        }
    }
}