using Code;

namespace Test
{
    public class TestStringManipulator
    {
        StringManipulator stringManipulator;
        [SetUp]
        public void Setup()
        {
            stringManipulator = new StringManipulator();
        }
        [Test]
        public void TestConcatenate()
        {
            Assert.AreEqual("HelloWorld", stringManipulator.Concatenate("Hello", "World"));
        }
        [Test]
        public void TestConcatenateWithEmptyString1()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate("", "World"));
        }
        [Test]
        public void TestConcatenateWithEmptyString2()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate("Hello", ""));
        }
        [Test]
        public void TestConcatenateWithEmptyString()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate("", ""));
        }
        [Test]
        public void TestConcatenateWithNullString1()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate(null, "World"));
        }
        [Test]
        public void TestConcatenateWithNullString2()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate("Hello", null));
        }
        [Test]
        public void TestConcatenateWithNullString()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate(null, null));
        }
        [Test]
        public void TestConcatenateWithNullStringAndEmptyString()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate(null, ""));
        }
        [Test]
        public void TestConcatenateWithEmptyStringAndNullString()
        {
            Assert.Throws<NullReferenceException>(() => stringManipulator.Concatenate("", null));
        }
    }
}
