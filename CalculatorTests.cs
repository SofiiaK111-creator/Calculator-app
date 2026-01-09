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

    #region Add Tests

    [Test]
    public void Add_TwoPositiveNumbers_ReturnsCorrectData()
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

    [TestCase(-1, 1, 0)]
    [TestCase(0, 5, 5)]
    [TestCase(-2, -3, -5)]
    public void Add_VariousInputs_ReturnsCorrectData(double a, double b, double expected)
    {
        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    #endregion

    #region Subtract Tests

    [Test]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectData()
    {
        // Arrange
        double a = 5.0;
        double b = 3.0;
        double expected = 2.0;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(-1, 1, -2)]
    [TestCase(0, 5, -5)]
    [TestCase(-2, -2, 0)]
    public void Subtract_VariousInputs_ReturnsCorrectSum(double a, double b, double expected)
    {
        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    #endregion


    #region Multiply Tests

    [Test]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectData()
    {
        // Arrange
        double a = 5.0;
        double b = 3.0;
        double expected = 15.0;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(-1, 1, -1)]
    [TestCase(0, 5, 0)]
    [TestCase(-2, -3, 6)]
    public void Multiply_VariousInputs_ReturnsCorrectSum(double a, double b, double expected)
    {
        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    #endregion
}


