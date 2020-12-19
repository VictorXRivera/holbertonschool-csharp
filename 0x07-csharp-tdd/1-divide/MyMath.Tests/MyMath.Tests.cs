using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        private int[,] _test_matrix = new int[,]
        {
            {0, 2, 10},
            {4, 8, 20}
        };

        [Test]
        public void test_division_of_matrix()
        {
            int[,] result = MyMath.Matrix.Divide(_test_matrix, 1);
            Assert.AreEqual(result, _test_matrix);
            Assert.AreNotEqual(result, _test_matrix);
        }

        [Test]
        public void test_division_of_matrix_2()
        {
            int[,] result = MyMath.Matrix.Divide(_test_matrix, 2);
            int[,] expected = new int[,]
            {
                {0, 1, 5},
                {2, 4, 10}
            };
            Assert.AreEqual(result, expected);
            Assert.AreNotEqual(result, _test_matrix);
        }

        [Test]
        public void test_division_by_0()
        {
            try
            {
                int[,] result = MyMath.Matrix.Divide(_test_matrix, 0);
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