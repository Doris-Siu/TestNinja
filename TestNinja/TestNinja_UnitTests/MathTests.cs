using TestNinjaDotNetSeven.Fundamentals;

namespace TestNinja_UnitTests;

public class MathTests
{
    private TestNinjaDotNetSeven.Fundamentals.Math _math;

    [SetUp]
    public void Setup()
    {
        _math = new TestNinjaDotNetSeven.Fundamentals.Math();
    }

    [Test]
    public void Add_WhenCalled_ReturnSumOfAgruments()
    {
        // Arrange
        //var math = new TestNinjaDotNetSeven.Fundamentals.Math();

        // Act
        var result = _math.Add(1, 2);

        // Assert
        Assert.That(result, Is.EqualTo(3));
        
        
    }

    //[Test]
    //public void Max_FirstAgrumentIsGreater_ReturnFirstAgrument()
    //{
    //    var result = _math.Max(2, 1);

    //    Assert.That(result, Is.EqualTo(2));

    //}

    //[Test]
    //public void Max_SecondAgrumentIsGreater_ReturnSecondAgrument()
    //{
    //    var result = _math.Max(1, 2);

    //    Assert.That(result, Is.EqualTo(2));

    //}

    //[Test]
    //public void Max_AgrumentsAreEqual_ReturnSameAgrument() // edge case
    //{
    //    var result = _math.Max(1, 1);

    //    Assert.That(result, Is.EqualTo(1));

    //}

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(1, 2, 2)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
    {
        var result = _math.GetOddNumbers(5);

        //            Assert.That(result, Is.Not.Empty);

        //            Assert.That(result.Count(), Is.EqualTo(3));

        //            Assert.That(result, Does.Contain(1));
        //            Assert.That(result, Does.Contain(3));
        //            Assert.That(result, Does.Contain(5));

        Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

        //            Assert.That(result, Is.Ordered);
        //            Assert.That(result, Is.Unique);

    }


}
