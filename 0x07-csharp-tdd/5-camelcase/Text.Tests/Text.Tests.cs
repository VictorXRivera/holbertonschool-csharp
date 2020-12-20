using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void empty_str()
        {
            string s = "";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Camel_case()
        {
            string s = "WipeOut";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void no_camelcase()
        {
            string s = "omega";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void one_camel()
        {
            string s = "Collection";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void crazy_camel()
        {
            string s = "“helloWorldIAmHere”";
            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(4, result);
        }
    }
}