using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
using DentalClinic.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        //
        private readonly IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        // GET: api/<WorkerController>
        [HttpGet]
        public DbSet<Worker> Get()
        {
            return _workerService.GetAll();
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var a = _workerService.GetById(id);
            if (a == null)
                return NotFound();
            return Ok(a);
        }

        //GET by Profession
        [HttpGet("{profession}")]
        public ActionResult Get(ProfessionsEnum profession)
        {
            var a = _workerService.GetByProfession(profession);
            if (a == null)
                return NotFound();
            return Ok(a);
        }

        // POST api/<WorkerController>
        [HttpPost]
        public ActionResult Post([FromBody] Worker w)
        {
            Task<bool> b = _workerService.Post(w);
            if (b.IsCompletedSuccessfully)
                return Created("The object was successfully added", w);
            return BadRequest("try again");
        }

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Worker w)
        {
            Task<bool> b = _workerService.Put(id, w);
            if (b.IsCompletedSuccessfully)
                return Created("The object was successfully added", w);
            return BadRequest("try again");
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Task<bool> b = _workerService.Delete(id);
            if (b.IsCompletedSuccessfully)
                return Ok("The object has been successfully deleted");
            return NotFound("The object was not found or could not be deleted");
        }
    }
}
