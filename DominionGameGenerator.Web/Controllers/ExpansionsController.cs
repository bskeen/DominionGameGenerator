using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DominionGameGenerator.Services;
using DominionGameGenerator.Services.DataTransferObjects;
using DominionGameGenerator.Web.Models;

namespace DominionGameGenerator.Web.Controllers
{
    [Route("api/[controller]")]
    public class ExpansionsController : Controller
    {
        private readonly IExpansionService _expansionService;

        public ExpansionsController(IExpansionService expansionService)
        {
            _expansionService = expansionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<ExpansionDto> expansions = _expansionService.GetExpansions();
            return ApiResult<ExpansionDto>.GetCollection(expansions, expansions.Count(), expansions.Count());
        }
    }
}
