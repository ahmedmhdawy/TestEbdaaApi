using EbdaaApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbdaaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _db;

        public ValuesController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var vas = await _db.TbValues.ToListAsync();
            return new JsonResult(vas);
        }
    }
}
