
using exp4net.function;
using NUnit.Framework;

namespace test
{
    public class TestFuntion
    {
        [Test]
        public void TestIsValidFunctionName()
        {

            


         


            Assert.IsFalse(Function.IsValidFunctionName(null));
            Assert.IsFalse(Function.IsValidFunctionName(" "));
            Assert.IsFalse(Function.IsValidFunctionName(""));
            Assert.IsTrue(Function.IsValidFunctionName("_"));
            Assert.IsTrue(Function.IsValidFunctionName("a"));
            Assert.IsFalse(Function.IsValidFunctionName("1_"));
            Assert.IsTrue(Function.IsValidFunctionName("a123_"));
            Assert.IsFalse(Function.IsValidFunctionName("a123%_"));
            Assert.IsFalse(Function.IsValidFunctionName("%a123_"));
        }
    }
}