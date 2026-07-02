using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        // Runs before every test
        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        // Runs after every test
        [TearDown]
        public void Cleanup()
        {
            calculator.AllClear();
        }

        // ---------------- Addition ----------------

        [Test]
        public void Addition_ShouldReturnCorrectSum()
        {
            double result = calculator.Addition(10, 20);

            Assert.That(result, Is.EqualTo(30));
        }

        [TestCase(10, 20, 30)]
        [TestCase(15, 25, 40)]
        [TestCase(-5, 5, 0)]
        [TestCase(2.5, 3.5, 6)]
        public void Addition_TestCases(double a, double b, double expected)
        {
            double result = calculator.Addition(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ---------------- Subtraction ----------------

        [TestCase(20, 10, 10)]
        [TestCase(5, 10, -5)]
        [TestCase(-5, -5, 0)]
        public void Subtraction_TestCases(double a, double b, double expected)
        {
            double result = calculator.Subtraction(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ---------------- Multiplication ----------------

        [TestCase(10, 5, 50)]
        [TestCase(-5, 2, -10)]
        [TestCase(0, 100, 0)]
        public void Multiplication_TestCases(double a, double b, double expected)
        {
            double result = calculator.Multiplication(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ---------------- Division ----------------

        [TestCase(20, 5, 4)]
        [TestCase(15, 3, 5)]
        [TestCase(-10, 2, -5)]
        public void Division_TestCases(double a, double b, double expected)
        {
            double result = calculator.Division(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        // ---------------- Exception Test ----------------

        [Test]
        public void Division_ByZero_ShouldThrowArgumentException()
        {
            Assert.That(() => calculator.Division(10, 0),
                Throws.TypeOf<ArgumentException>()
                      .With.Message.EqualTo("Second Parameter Can't be Zero"));
        }

        // ---------------- Property Test ----------------

        [Test]
        public void GetResult_ShouldReturnLastCalculatedValue()
        {
            calculator.Addition(10, 5);

            Assert.That(calculator.GetResult, Is.EqualTo(15));
        }

        // ---------------- AllClear Test ----------------

        [Test]
        public void AllClear_ShouldResetResultToZero()
        {
            calculator.Addition(10, 5);

            calculator.AllClear();

            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }

        // ---------------- Ignore Example ----------------

        [Test]
        [Ignore("Example of Ignore attribute.")]
        public void Ignored_Test()
        {
            Assert.Fail();
        }
    }
}