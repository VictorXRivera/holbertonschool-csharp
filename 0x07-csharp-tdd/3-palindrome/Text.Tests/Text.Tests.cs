using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Str
    {
        [Test]
        public void false_palindrome()
        {
            string false_pali = "Wipeout";
            bool result = Text.Str.IsPalindrome(false_pali);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void true_palindrome()
        {
            string true_pali = "racecar";
            var result = Text.Str.IsPalindrome(true_pali);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void space_in_between_str()
        {
            string space_pali = " ";
            var result = Text.Str.IsPalindrome(space_pali);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void string_pali()
        {
            string str_pali = "A man, a plan, a canal: Panama.";
            var result = Text.Str.IsPalindrome(str_pali);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Capital_pali()
        {
            string C_pali = "Racecar";
            var result = Text.Str.IsPalindrome(C_pali);
            Assert.AreEqual(true, result);
        }
    }
}