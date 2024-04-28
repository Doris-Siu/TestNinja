using TestNinjaDotNetSeven.Fundamentals;

namespace TestNinja_UnitTests;

public class ErrorLoggerTests
{
    private ErrorLogger _logger;

    [SetUp]
    public void Setup()
    {
        _logger = new ErrorLogger();

    }

    [Test]
    public void Log_WhenCalled_SetTheLastErrorProperty()
    {

        _logger.Log("a");

        Assert.That(_logger.LastError, Is.EqualTo("a"));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidError_ThrowArgumentNullException(string error)
    {
        // use lambda function to test method throwing exception
        Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
    }

    [Test]
    public void Log_ValidError_RaiseErrorLoggedEvent()
    {
        var id = Guid.Empty;

        // subscribe the event before ACT
        _logger.ErrorLogged += (sender, args) => { id = args; };
        _logger.Log("a");

        Assert.That(id, Is.Not.EqualTo(Guid.Empty));

    }

}


