using Xunit;
using DockerSampleWebApi.Controllers;
using System.Collections.Generic;
using Moq;
using Microsoft.Extensions.Logging;

namespace DockerSampleWebApi.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            _mockLogger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_mockLogger.Object);
        }

        [Fact]
        public void Get_ReturnsListOfWeatherForecasts()
        {
            // Arrange
            // Any necessary arranging steps

            // Act
            var result = _controller.Get();

            // Assert
            Assert.IsType<WeatherForecast[]>(result);
            Assert.Equal(5, result.Count());
        }

        // Add more tests as needed
    }
}