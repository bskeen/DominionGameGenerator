using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DominionGameGenerator.Web.Models
{
    public class ApiResult<T>
    {
        public IEnumerable<T> Items { get; set; }

        public int ResultCount { get; set; }

        public int TotalResultCount { get; set; }

        public static JsonResult GetSingle(T item)
        {
            return new JsonResult(new ApiResult<T>()
            {
                Items = new List<T> { item },
                ResultCount = 1,
                TotalResultCount = 1
            });
        }

        public static JsonResult GetCollection(IEnumerable<T> items, int resultCount, int totalResultCount)
        {
            return new JsonResult(new ApiResult<T>()
            {
                Items = items,
                ResultCount = resultCount,
                TotalResultCount = totalResultCount
            });
        }
    }
}
