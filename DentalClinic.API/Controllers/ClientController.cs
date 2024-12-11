using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
using DentalClinic.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: api/<Client>
        [HttpGet]
        public DbSet<Client> Get()
        {
            return _clientService.GetAll();
        }

        // GET api/<Client>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var a = _clientService.GetById(id);
            if (a == null)
                return NotFound();
            return Ok(a);
        }

        //GET by medicalInsurance
        [HttpGet("{medicalInsurance}")]
        public ActionResult Get(MedicalInsuranceEnum medicalInsurance)
        {
            var a = _clientService.GetByMedicalInsurance(medicalInsurance);
            if (a == null)
                return NotFound();
            return Ok(a);
        }
        // POST api/<Client>
        [HttpPost]
        public ActionResult Post([FromBody] Client c)
        {
            Task<bool> b = _clientService.Post(c);
            if (b.IsCompletedSuccessfully)
                return Created("The object was successfully added", c);
            return BadRequest("try again");
        }

        // PUT api/<Client>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client c)
        {
            Task<bool> b = _clientService.Put(id, c);
            if (b.IsCompletedSuccessfully)
                return Created("The object was successfully added", c);
            return BadRequest("try again");
        }

        // DELETE api/<Client>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Task<bool> b = _clientService.Delete(id);
            if (b.IsCompletedSuccessfully)
                return Ok("The object has been successfully deleted");
            return NotFound("The object was not found or could not be deleted");
        }
    }
}
