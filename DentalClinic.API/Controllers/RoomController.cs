using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IDataContext _context;

        public RoomController(IDataContext data)
        {
            _context = data;
        }

        // GET: api/<RoomController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return "" + _context.Rooms.ToString();
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "" + _context.Rooms.FirstOrDefault(r => r.Id == id, _context.Rooms.First()).ToString();
        }

        //GET by floor
        [HttpGet("{floor}")]
        public string GetFloor(int floor)
        {
            return "" + _context.Rooms.Where(r => r.Floor == floor).ToList().ToString();
        }

        //GET by suitabe
        [HttpGet("{suitable}")]
        public string Get(SuitableEnum suitable)
        {
            //  List<Client> clients = _context.Clients.Where(c => c.MedicalInsurance == medicalInsurance).ToList();

            return _context.Rooms.Where(r => r.Suitable == suitable).ToList().ToString();
        }

        // POST api/<RoomController>
        [HttpPost]
        public void Post([FromBody] Room r)
        {
            _context.Rooms.Add(new Room(r.Floor, r.Number, r.Suitable));
        }

        // PUT api/<RoomController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Room r)
        {
            Room room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            room.Number = r.Number;
            room.Floor = r.Floor;
            room.Suitable = r.Suitable;
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Rooms.Remove(_context.Rooms.FirstOrDefault(r => r.Id == id));
        }
    }
}
