using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using DBHelper;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        // GET: api/Hotel
        [HttpGet]
        public string Get()
        {
            var DataTable = SQLOperation.ExecuteCommand(Startup.ConnectionString, "gethotels");
            return JsonConvert.SerializeObject(DataTable);
        }

        // GET: api/Hotel/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hotel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hotel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
