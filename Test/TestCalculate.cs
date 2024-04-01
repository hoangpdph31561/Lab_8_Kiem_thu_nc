using Code;

namespace Test
{
    public class TestCalculate
    {
        Calculate calculate;
        [SetUp]
        public void Setup()
        {
            calculate = new Calculate();
        }
        [Test]
        public void TestScoreGPA()
        {
            Assert.AreEqual(7, calculate.ScoreGPA(7, 7, 7));
        }
        [Test]
        public void TestScoreGPAWithNegativeMath()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(-1, 7, 7));
        }
        [Test]
        public void TestScoreGPAWithNegativeScience()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(8, -1, 7));
        }
        [Test]
        public void TestScoreGPAWithNegativeChemistry()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(8, 7, -1));
        }
        [Test]
        public void TestScoreGPAWithMathGreaterThan10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(11, 7, 7));
        }
        [Test]
        public void TestScoreGPAWithScienceGreaterThan10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(8, 11, 7));
        }
        [Test]
        public void TestScoreGPAWithChemistryGreaterThan10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(8, 7, 11));
        }
        [Test]
        public void TestScoreGPAWithNegativeMathAndScience()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(-1, -1, 7));
        }
        [Test]
        public void TestScoreGPAWithNegativeMathAndChemistry()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(-1, 7, -1));
        }
        [Test]
        public void TestScoreGPAWithNegativeScienceAndChemistry()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.ScoreGPA(8, -1, -1));
        }
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(55, calculate.Sum(10));
        }
        [Test]
        public void TestSumWithNegativeInput()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.Sum(-1));
        }
        [Test]
        public void TestSumWithZeroInput()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculate.Sum(0));
        }
        [Test]
        public void TestSumWithOneInput()
        {
            Assert.AreEqual(1, calculate.Sum(1));
        }
        [Test]
        public void TestSumWithTwoInput()
        {
            Assert.AreEqual(3, calculate.Sum(2));
        }
        [Test]
        public void TestSumWithThreeInput()
        {
            Assert.AreEqual(6, calculate.Sum(3));
        }
        [Test]
        public void TestSumWithFourInput()
        {
            Assert.AreEqual(10, calculate.Sum(4));
        }
        [Test]
        public void TestSumWithFiveInput()
        {
            Assert.AreEqual(15, calculate.Sum(5));
        }
        [Test]
        public void TestSumWithSixInput()
        {
            Assert.AreEqual(21, calculate.Sum(6));
        }
        [Test]
        public void TestSumWithSevenInput()
        {
            Assert.AreEqual(28, calculate.Sum(7));
        }

    }
}
