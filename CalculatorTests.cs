using CalculatorApp;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = 5.0;
        double b = 3.0;
        double expected = 8.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = -5.0;
        double b = -3.0;
        double expected = -8.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Zero_ReturnsCorrectSum()
    {
        // Arrange
        double a = -5.0;
        double b = 0.0;
        double expected = -5.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


}

