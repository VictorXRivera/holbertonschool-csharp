using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void repeating_string()
        {
            string s = "aabbcc";
            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void non_repeating_string()
        {
            string s = "test";
            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void null_check()
        {
            int result = Text.Str.UniqueChar(null);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void unique_repeat()
        {
            int result = Text.Str.UniqueChar("aaabccc");
            Assert.AreEqual(result, 3);
        }
    }
}