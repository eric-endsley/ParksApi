using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parks.Models;

namespace Parks.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class NatlParksController : ControllerBase
    {
        private ParksContext _db;

        public NatlParksController(ParksContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<NatlPark>> Get()
        {
            return _db.NatlParks.ToList();
        }

        [HttpPost]
        public void Post([FromBody] NatlPark natlPark)
        {
            _db.NatlParks.Add(natlPark);
            _db.SaveChanges();
        }
    }
}