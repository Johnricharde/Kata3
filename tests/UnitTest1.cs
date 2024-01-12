using Microsoft.VisualStudio.TestPlatform.TestHost;
using Kata3;
namespace tests
{

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata3.Program.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata3.Program.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata3.Program.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata3.Program.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata3.Program.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata3.Program.SpinWords("Just kidding there is still one more"));
        }
    }
}