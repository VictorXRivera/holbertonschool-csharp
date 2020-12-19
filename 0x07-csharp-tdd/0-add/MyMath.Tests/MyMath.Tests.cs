using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void test_add()
        {
            int result = 6;

            int sum = MyMath.Operations.Add(3, 3);

            Assert.AreEqual(result, sum);
        }
    }
}