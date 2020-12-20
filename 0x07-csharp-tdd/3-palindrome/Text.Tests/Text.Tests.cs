using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Str
    {
        [Test]
        public void false_palindrome()
        {
            string false_pali = "wipeout";
            bool result = Text.Str.IsPalindrome(false_pali);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void true_palindrome()
        {
            string true_pali = "racecar";
            bool result = Text.Str.IsPalindrome(true_pali);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void space_in_between_str()
        {
            string space_pali = " ";
            bool result = Text.Str.IsPalindrome(space_pali);
            Assert.AreEqual(true, result);
        }
    }
}