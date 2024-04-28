using TestNinjaDotNetSeven.Fundamentals;

namespace TestNinja_UnitTests;

public class CustomerControllerTests
{
    private CustomerController _controller;

    [SetUp]
    public void Setup()
    {
        _controller = new CustomerController();
    }

    [Test]
    public void GetCustomer_IdIsZero_ReturnNotFound()
    {

        var result = _controller.GetCustomer(0);

        // NotFound 
        Assert.That(result, Is.TypeOf<NotFound>());

        // NotFound or one of its derivatives 
        // Assert.That(result, Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdIsNotZero_ReturnOk()
    {
        var result = _controller.GetCustomer(1);

        // NotFound 
        Assert.That(result, Is.TypeOf<Ok>());

    }
}

