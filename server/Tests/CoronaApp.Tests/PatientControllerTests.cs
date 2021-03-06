using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;

namespace CoronaApp.Tests
{
    public class PatientControllerTests : IClassFixture<WebApplicationFactory<Api.Startup>>
    {
        private readonly WebApplicationFactory<Api.Startup> _factory;
        public PatientControllerTests(WebApplicationFactory<Api.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void GetPatient_ById_ReturnPatient()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/patient/1");

            // Assert
            response.EnsureSuccessStatusCode();
            var response1 = response.Content.ReadAsStringAsync().Result;
           // Assert.

        }
    }
}
