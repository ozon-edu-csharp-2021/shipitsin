using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.MerchandiseService.Models;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.Controllers
{
    [ApiController]
    [Route("v1/api/merch")]
    [Produces("application/json")]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseService _merchandiseService;

        public MerchandiseController(IMerchandiseService merchandiseService)
        {
            _merchandiseService = merchandiseService;
        }

        [HttpGet("employee/{id:int}/merch_type/{merch_type:int}")]
        public async Task<ActionResult<string>> IssueMerch(int id, int merch_type, CancellationToken token)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("employee/{id:int}")]
        public async Task<ActionResult<List<MerchType>>> GetIssuedMerch(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}