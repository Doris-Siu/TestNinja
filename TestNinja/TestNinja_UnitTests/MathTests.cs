using TestNinjaDotNetSeven.Fundamentals;

namespace TestNinja_UnitTests;

public class MathTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_WhenCalled_ReturnSumOfAgruments()
    {
        // Arrange
        var math = new TestNinjaDotNetSeven.Fundamentals.Math();

        // Act
        var result = math.Add(1, 2);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    
}
