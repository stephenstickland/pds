using MemberClient;
using Moq;
using Moq.Protected;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MemberClientTests
{
    public class HttpMemberClientTest
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
                   Content = new StringContent(ResponseXml.MemberResponse),
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

            var client = new HttpMemberClient(httpClientFactoryMock.Object);
            Assert.NotNull(client);
        }

        [Fact]
        public async void GetMember()
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
                   Content = new StringContent(ResponseXml.MemberResponse),
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

            var client = new HttpMemberClient(httpClientFactoryMock.Object);
            Assert.NotNull(client);

            // ACT
            var result = await client.GetMember(579);

            // ASSERT
            Assert.NotNull(result);
            Assert.Equal(1, result.Count);

            // also check the 'http' call was like we expected it
            var expectedUri = new Uri("http://data.parliament.uk/membersdataplatform/services/mnis/members/query/house=Commons|id=579");

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

        [Fact]
        public async void GetMembers()
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
                   Content = new StringContent(ResponseXml.MembersResponse),
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

            var client = new HttpMemberClient(httpClientFactoryMock.Object);
            Assert.NotNull(client);

            // ACT
            var result = await client
               .GetMembers();

            // ASSERT
            Assert.NotNull(result);
            Assert.Equal(650, result.Count);

            // also check the 'http' call was like we expected it
            var expectedUri = new Uri("http://data.parliament.uk/membersdataplatform/services/mnis/members/query/house=Commons");

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
