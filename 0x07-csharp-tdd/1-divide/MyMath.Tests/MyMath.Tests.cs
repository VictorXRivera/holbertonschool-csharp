using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        private int[,] test_matrix = new int[,]
        {
            {0, 1, 10},
            {2, 8, 20}
        };

        [Test]
        public void test_division_by_0()
        {
            try
            {
                int[,] result = MyMath.Matrix.Divide(test_matrix, 0);
                Assert.AreEqual(result, null);
            }
            catch (System.DivideByZeroException)
            {
                Assert.Fail();
                return;
            }
        }

        [Test]
        public void test_division_by_null()
        {
            try
            {
                int[,] result = MyMath.Matrix.Divide(null, 2);
                Assert.AreEqual(result, null);
            }
            catch (System.Exception)
            {
                Assert.Fail();
                return;
            }
        }
    }
}