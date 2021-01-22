using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parks.Models;

namespace Parks.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NatlPark natlPark)
        {
            natlPark.NatlParkId = id;
            _db.Entry(natlPark).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.NatlParks.FirstOrDefault(entry => entry.NatlParkId == id);
            _db.NatlParks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}