using Application.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Application.Tests.Controllers;

public class Tests
{
    private HealthController _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new HealthController();
    }

    [Test]
    public void HealthCheck_Should_Pass()
    {
        IActionResult actionResult = _sut.Check();
        var contentResult = actionResult as OkResult;

        Assert.That(contentResult, Is.Not.Null);
        Assert.That(contentResult.StatusCode, Is.EqualTo(200));
    }
}