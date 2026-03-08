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
        [Test]
        public void TestSortedMax()
        {
            Assert.Throws<ArgumentNullException>(() => SortedMax(null));
        }
        [Test]
        public void TestSortedMax2()
        {
            Assert.That(() => SortedMax(new string[] { "кот собака мышь", "Hello, World!", "один, два, три, 4, 5" }), Is.EqualTo(new string[] { "один", "Hello", "собака" }));
        }


        /// Test #4.
        [Test]
        public void TestToLow()
        {
            Assert.That(() => ToLow("Привет Всем! Это тестовая строка.\nВторая строка."), Is.EqualTo(new string[] { "привет", "всем", "это", "тестовая", "строка", "вторая", "строка" }));
        }


        /// Test #5.
        [Test]        
        public void TestCountOfIndex1()
        {
            Assert.That(() => CountOfIndex("123456 78901 654321 12345 999999"), Is.EqualTo(3));
        }
        [Test]
        public void TestCountOfIndex2()
        {
            Assert.That(() => CountOfIndex("abc123 456789 12 345678 x123456"), Is.EqualTo(2));
        }
        [Test]
        public void TestCountOfIndex3()
        {
            Assert.That(() => CountOfIndex("нет цифр"), Is.EqualTo(0));
        }


        /// Test #6.
        [Test]
        public void TestCountOfIndexRegex()
        {
            Assert.That(() => CountOfIndexRegex("123456 78901 654321 12345 999999"), Is.EqualTo(3));
        }
        [Test]
        public void TestCountOfIndexRegex2()
        {
            Assert.That(() => CountOfIndexRegex("123456, 654321 и 789012."), Is.EqualTo(3));
        }

    }
}
