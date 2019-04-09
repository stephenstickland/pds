using BusinessService;
using CalendarClient;
using MemberClient;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BusinessServiceTests
{
    public class BusinessServiceTest
    {
        [Fact]
        public void Construction()
        {
            Mock<IMemberClient> mockMemberClient = new Mock<IMemberClient>();
            Mock<ICalendarClient> mockCalendarClient = new Mock<ICalendarClient>();

            var service = new DefaultBusinessService(mockMemberClient.Object, mockCalendarClient.Object);

            Assert.NotNull(service);
        }

        [Fact]
        public async void GetWeek()
        {
            Mock<IMemberClient> mockMemberClient = new Mock<IMemberClient>();
            Mock<ICalendarClient> mockCalendarClient = new Mock<ICalendarClient>();

            mockMemberClient
                .Setup(c => c.GetMembers())
                .Returns(Task.FromResult((IList<MemberClient.Member>)new List<MemberClient.Member>()
                {
                    new MemberClient.Member()
                    {
                        Member_Id = 1
                    }
                }));

            mockCalendarClient
                .Setup(c => c.GetEvents(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .Returns(Task.FromResult((IList<CalendarClient.Event>)new List<CalendarClient.Event>()
                {
                    new CalendarClient.Event()
                    {
                        Members = new List<CalendarClient.Member>()
                        {
                            new CalendarClient.Member()
                            {
                                Id = 1
                            }
                        }
                    }
                }));

            var service = new DefaultBusinessService(mockMemberClient.Object, mockCalendarClient.Object);
            Assert.NotNull(service);

            var result = await service.GetWeek(DateTime.Now);
            Assert.NotNull(result);
            Assert.Single(result.BusinessItems);
            Assert.Single(result.BusinessItems[0].ApplicableMembers);

        }
    }
}
