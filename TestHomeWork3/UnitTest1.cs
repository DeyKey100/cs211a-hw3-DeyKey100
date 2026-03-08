using Homework3;
using static Homework3.HW3;

namespace TestHomeWork3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        /// Test #1
        [Test]
        public void TestAddSpace1()
        {
            Assert.That(() => AddSpace(new string[] { "abc", "abcde", "a", "abcdefg", "abcdefghi" }), Is.EqualTo(new string[] { "   abc   ", "  abcde  ", "    a    ", " abcdefg ", "abcdefghi" }));
        }
        [Test]
        public void TestAddSpace2()
        {
            Assert.Throws<ArgumentNullException>(() => AddSpace(null));
        }
        [Test]
        public void TestAddSpace3()
        {
            Assert.Throws<ArgumentException>(() => AddSpace(new string[] { "abama", "ro", "jpg" }));
        }


        /// Test #2.
        [Test]
        public void TestRCN()
        {
            Assert.That(() => RCN(new string[] { "C++", "PascalABC" }, "Я учу PascalABC, C#, C++"), Is.EqualTo("Я учу *********, C#, ***"));
        }
        [Test]
        public void TestRCN2() 
        {
                Assert.That(() => RCN(new string[] { "66", "5" }, "2 + 2 = 5 4, 6 + 6 = 66 12"), Is.EqualTo("2 + 2 = * 4, 6 + 6 = ** 12"));
        }


        /// Test #3.
        








    }
}
