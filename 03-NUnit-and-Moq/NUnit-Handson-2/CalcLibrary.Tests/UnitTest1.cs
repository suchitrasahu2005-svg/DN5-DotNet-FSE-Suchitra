using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    public class Tests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        // Parameterized Addition Test
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-5, 5, 0)]
        [TestCase(-10, -20, -30)]
        public void AdditionTest(double a, double b, double expected)
        {
            var result = calculator.Addition(a, b);
            Assert.AreEqual(expected, result);
        }

        // Parameterized Subtraction Test
        [TestCase(20, 10, 10)]
        [TestCase(15, 5, 10)]
        [TestCase(-5, -5, 0)]
        [TestCase(10, 20, -10)]
        public void SubtractionTest(double a, double b, double expected)
        {
            var result = calculator.Subtraction(a, b);
            Assert.AreEqual(expected, result);
        }

        // Parameterized Multiplication Test
        [TestCase(2, 3, 6)]
        [TestCase(5, 5, 25)]
        [TestCase(-2, 4, -8)]
        [TestCase(0, 10, 0)]
        public void MultiplicationTest(double a, double b, double expected)
        {
            var result = calculator.Multiplication(a, b);
            Assert.AreEqual(expected, result);
        }

        // Parameterized Division Test
        [TestCase(20, 4, 5)]
        [TestCase(15, 3, 5)]
        [TestCase(9, 3, 3)]
        [TestCase(10, 2, 5)]
        public void DivisionTest(double a, double b, double expected)
        {
            var result = calculator.Division(a, b);
            Assert.AreEqual(expected, result);
        }

        // Division by Zero Test
        [Test]
        public void DivisionByZeroTest()
        {
            var ex = Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
            Assert.AreEqual("Second Parameter Can't be Zero", ex.Message);
        }

        // Try-Catch Division by Zero Test
        [Test]
        public void DivisionByZeroTryCatchTest()
        {
            try
            {
                calculator.Division(10, 0);
                Assert.Fail("Exception was not thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Second Parameter Can't be Zero", ex.Message);
            }
        }

        // All Clear Test
        [Test]
        public void AllClearTest()
        {
            calculator.Addition(10, 20);
            calculator.AllClear();

            Assert.AreEqual(0, calculator.GetResult);
        }

        // Add and Clear Test
        [Test]
        public void TestAddAndClear()
        {
            calculator.Addition(20, 30);
            Assert.AreEqual(50, calculator.GetResult);

            calculator.AllClear();
            Assert.AreEqual(0, calculator.GetResult);
        }
    }
}