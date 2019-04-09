using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessService.Domain;
using CalendarClient;
using MemberClient;

namespace BusinessService
{
    public class DefaultBusinessService : IBusinessService
    {
        private static readonly int DAYS_IN_WEEK = 7;

        private IMemberClient _memberClient;

        private ICalendarClient _calendarClient;

        public DefaultBusinessService(IMemberClient memberClient, ICalendarClient calendarClient)
        {
            _memberClient = memberClient;
            _calendarClient = calendarClient;
        }

        public async Task<Week> GetWeek(DateTime startDate)
        {
            DateTime weekEnd = startDate.AddDays(DAYS_IN_WEEK);

            var members = await _memberClient.GetMembers();
            var events = await _calendarClient.GetEvents(startDate, weekEnd);

            var memberMap = new Dictionary<int, MemberClient.Member>();

            foreach (var member in members)
            {
                memberMap[member.Member_Id] = member;
            }

            var week = new Week(startDate, weekEnd);

            foreach (var evt in events)
            {
                List<Domain.Member> applicableMembers = new List<Domain.Member>();

                foreach(var member in evt.Members)
                {
                    applicableMembers.Add(new Domain.Member()
                    {
                        FullTitle = memberMap[member.Id].FullTitle,
                        MemberFrom = memberMap[member.Id].MemberFrom,
                        Party = memberMap[member.Id].Party
                    });
                }

                week.BusinessItems.Add(new BusinessItem()
                {
                    Description = evt.Description,
                    Category = evt.Category,
                    StartDate = evt.StartDate,
                    StartTime = evt.StartTime,
                    EndDate = evt.EndDate,
                    EndTime = evt.EndTime,
                    ApplicableMembers = applicableMembers
                });
            }

            return week;
        }
    }
}
