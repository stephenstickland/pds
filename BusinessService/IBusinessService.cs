using BusinessService.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public interface IBusinessService
    {
        Task<Period> GetItemsForPeriod(DateTime startDate, DateTime endDate);

        Task<BusinessItem> GetItem(DateTime startDate, DateTime endDate, int id);
    }
}
