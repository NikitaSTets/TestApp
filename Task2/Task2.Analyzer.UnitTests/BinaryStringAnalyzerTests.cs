using NUnit.Framework;

namespace Task2.Analyzer.UnitTests;

[TestFixture]
public class BinaryStringAnalyzerTests
{
    private BinaryStringAnalyzer _analyzer;

    [SetUp]
    public void Setup()
    {
        _analyzer = new BinaryStringAnalyzer();
    }

    [Test]
    [TestCase("1100")]
    [TestCase("1010")]
    [TestCase("111000")]
    [TestCase("10")]
    public void IsGoodBinaryString_ValidatesGoodString_ReturnsTrue(string input)
    {
        // Act
        var result = _analyzer.IsGoodBinaryString(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    [TestCase("1001")]
    [TestCase("0011")]
    [TestCase("1101")]
    [TestCase("1")]
    [TestCase("0")]
    [TestCase("")]
    [TestCase("_")]
    [TestCase("1_0")]
    public void IsGoodBinaryString_ValidatesBadString_ReturnsFalse(string input)
    {
        // Act
        var result = _analyzer.IsGoodBinaryString(input);

        // Assert
        Assert.IsFalse(result);
    }


    [Test]
    [TestCase("010")]
    [TestCase("1001")]
    [TestCase("01")]
    public void IsGoodBinaryString_ReturnsFalse_When_Prefix_Issue(string input)
    {
        // Act
        var result = _analyzer.IsGoodBinaryString(input);

        // Assert
        Assert.IsFalse(result);
    }
}