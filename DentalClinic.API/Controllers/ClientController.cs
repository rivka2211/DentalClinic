using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IDataContext _context;
        public ClientController(IDataContext data)
        {
            _context = data;
        }

        // GET: api/<Client>
        [HttpGet]
        public List<Client> Get()
        {
            return _context.Clients;
        }

        // GET api/<Client>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Client client = _context.Clients.Find(c => c.Id == id);
            if (client != null)
                return Ok(client);
            return NotFound($"no client with {id} id");
        }

        //GET by medicalInsurance
        [HttpGet("{medicalInsurance}")]
        public ActionResult Get(MedicalInsuranceEnum medicalInsurance)
        {
            List<Client> clients = _context.Clients.Where(c => c.MedicalInsurance == medicalInsurance).ToList();
            if (clients != null)
                return Ok(clients);
            return NotFound($"no client with {medicalInsurance} medicalInsurance");
        }
        // POST api/<Client>
        [HttpPost]
        public void Post([FromBody] Client c)
        {
            _context.Clients.Add(new Client(c.Id, c.Name, c.Address, c.MedicalInsurance, c.BirthDate));
        }

        // PUT api/<Client>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client c)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.Id == id);
            client.Id = c.Id;
            client.Name = c.Name;
            client.Address = c.Address;
            client.MedicalInsurance = c.MedicalInsurance;
            client.BirthDate = c.BirthDate;
        }

        // DELETE api/<Client>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Clients.Remove(_context.Clients.FirstOrDefault(c => c.Id == id));
        }
    }
}
