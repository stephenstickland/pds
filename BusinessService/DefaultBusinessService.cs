using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService.Domain;
using CalendarClient;
using MemberClient;

namespace BusinessService
{
    public class DefaultBusinessService : IBusinessService
    {
        private IMemberClient _memberClient;

        private ICalendarClient _calendarClient;

        public DefaultBusinessService(IMemberClient memberClient, ICalendarClient calendarClient)
        {
            _memberClient = memberClient;
            _calendarClient = calendarClient;
        }

        public async Task<BusinessItem> GetItem(int id)
        {
            var members = await _memberClient.GetMembers();
            var evt = await _calendarClient.GetEvent(id);

            var memberMap = new Dictionary<int, MemberClient.Member>();

            foreach (var member in members)
            {
                memberMap[member.Member_Id] = member;
            }

            List<Domain.Member> applicableMembers = new List<Domain.Member>();

            foreach (var member in evt.Members)
            {
                applicableMembers.Add(new Domain.Member()
                {
                    FullTitle = memberMap[member.Id].FullTitle,
                    MemberFrom = memberMap[member.Id].MemberFrom,
                    Party = memberMap[member.Id].Party
                });
            }

            var businessItem = new BusinessItem()
            {
                Id = evt.Id,
                Description = evt.Description,
                Category = evt.Category,
                StartDate = evt.StartDate,
                StartTime = evt.StartTime,
                EndDate = evt.EndDate,
                EndTime = evt.EndTime,
                ApplicableMembers = applicableMembers
            };
            
            return businessItem;
        }

        public async Task<Period> GetItemsForPeriod(DateTime startDate, DateTime endDate)
        {
            var members = await _memberClient.GetMembers();
            var events = await _calendarClient.GetEvents(startDate, endDate);

            var period = new Period(startDate, endDate);

            var memberMap = new Dictionary<int, MemberClient.Member>();

            foreach (var member in members)
            {
                memberMap[member.Member_Id] = member;
            }
    
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

                period.BusinessItems.Add(new BusinessItem()
                {
                    Id = evt.Id,
                    Description = evt.Description,
                    Category = evt.Category,
                    StartDate = evt.StartDate,
                    StartTime = evt.StartTime,
                    EndDate = evt.EndDate,
                    EndTime = evt.EndTime,
                    SortOrder = evt.SortOrder,
                    ApplicableMembers = applicableMembers
                });
            }

            period.BusinessItems = period.BusinessItems
                .OrderBy(x => x.StartDate)
                .ThenBy(x => x.SortOrder)
                .ToList();

            return period;
        }

    }
}
