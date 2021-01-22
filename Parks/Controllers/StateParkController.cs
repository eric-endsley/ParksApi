using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parks.Models;

namespace Parks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateParksController : ControllerBase
    {
        private ParksContext _db;

        public StateParksController(ParksContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get()
        {
            return _db.StateParks.ToList();
        }

        [HttpPost]
        public void Post([FromBody] StatePark statePark)
        {
            _db.StateParks.Add(statePark);
            _db.SaveChanges();
        }
    }
}
