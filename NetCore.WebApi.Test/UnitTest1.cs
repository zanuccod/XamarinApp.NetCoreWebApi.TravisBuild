using Microsoft.Extensions.Logging.Abstractions;
using NetCore.WebApi.Controllers;
using NUnit.Framework;

namespace NetCore.WebApi.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var controller = new WeatherForecastController(new NullLogger<WeatherForecastController>());

            var result = controller.TestMethod();

            Assert.AreEqual(1, result);
        }
    }
}