using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void empty_str()
        {
            int empty_string = 0;
            Assert.AreEqual(empty_string, 0);
        }

        [Test]
        public void Camel_case()
        {
            string s = "WipeOut";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void no_camelcase()
        {
            string s = "omega";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void one_camel()
        {
            string s = "Collection";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(result, 1);
        }
    }
}