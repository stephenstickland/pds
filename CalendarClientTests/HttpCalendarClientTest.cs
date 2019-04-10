using CalendarClient;
using Moq;
using Moq.Protected;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CalendarClientTests
{
    public class HttpCalendarClientTest
    {
        [Fact]
        public void Construction()
        {
            // ARRANGE
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
               .Protected()
               // Setup the PROTECTED method to mock
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>()
               )
               // prepare the expected response of the mocked http call
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(ResponseXml.CalendarResponse),
               })
               .Verifiable();

            // use real http client with mocked handler here
            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };

            // create the mock client factory mock
            var httpClientFactoryMock = new Mock<IHttpClientFactory>();

            // setup the method call
            httpClientFactoryMock.Setup(x => x.CreateClient(It.IsAny<string>()))
                                 .Returns(httpClient);

            var client = new HttpCalendarClient(httpClientFactoryMock.Object);
            Assert.NotNull(client);
        }

        [Fact]
        public async void GetEvents()
        {
            // ARRANGE
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
               .Protected()
               // Setup the PROTECTED method to mock
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>()
               )
               // prepare the expected response of the mocked http call
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent(ResponseXml.CalendarResponse),
               })
               .Verifiable();

            // use real http client with mocked handler here
            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };

            // create the mock client factory mock
            var httpClientFactoryMock = new Mock<IHttpClientFactory>();

            // setup the method call
            httpClientFactoryMock.Setup(x => x.CreateClient(It.IsAny<string>()))
                                 .Returns(httpClient);

            var client = new HttpCalendarClient(httpClientFactoryMock.Object);
            Assert.NotNull(client);

            // ACT
            var result = await client
               .GetEvents(DateTime.Parse("2019-04-09"), DateTime.Parse("2019-04-09"));

            // ASSERT
            Assert.NotNull(result);
            Assert.Equal(128, result.Count);

            // also check the 'http' call was like we expected it
            var expectedUri = new Uri("http://service.calendar.parliament.uk/calendar/events/list.xml?house=Commons&startDate=2019-04-09&endDate=2019-04-09");

            handlerMock.Protected().Verify(
               "SendAsync",
               Times.Exactly(1), // we expected a single external request
               ItExpr.Is<HttpRequestMessage>(req =>
                  req.Method == HttpMethod.Get  // we expected a GET request
                  && req.RequestUri == expectedUri // to this uri
               ),
               ItExpr.IsAny<CancellationToken>()
            );
        }
    }
}
