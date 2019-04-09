using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;
using BusinessService;
using BusinessService.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace BusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private IBusinessService _service;

        private IMemoryCache _cache;

        public BusinessController(IMemoryCache cache, IBusinessService service)
        {
            _cache = cache;
            _service = service;
        }

        [HttpGet("period/{startDate}/{endDate}/{id}")]
        public async Task<ActionResult<BusinessItem>> Get(DateTime startDate, DateTime endDate, int id)
        {
            BusinessItem cachedObject = (BusinessItem)_cache.Get(Request.Path);
            if (cachedObject == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(7);
                cachedObject = await _service.GetItem(startDate, endDate, id);
                _cache.Set(Request.Path, cachedObject);
            }
            return cachedObject;           
        }

        [HttpGet("period/{startDate}/{endDate}")]
        public async Task<ActionResult<Period>> Get(DateTime startDate, DateTime endDate)
        {
            Period cachedObject = (Period)_cache.Get(Request.Path);
            if (cachedObject == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(7);
                cachedObject = await _service.GetItemsForPeriod(startDate, endDate);
                _cache.Set(Request.Path, cachedObject);
            }
            return cachedObject;
        }
    }
}
