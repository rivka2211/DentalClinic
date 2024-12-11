//using DentalClinic.Classes;
using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DentalClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public DbSet<Appointment> Get()
        {
            return _appointmentService.GetAll();
        }

        // GET api/<AppointmentController>/5
        [HttpGet("/id/{id}")]
        public ActionResult Get(int id)
        {
            var a = _appointmentService.GetByid(id);
            if (a == null)
                return NotFound();
            return Ok(a);
        }

        [HttpGet("{client}")]
        public ActionResult Get([FromBody] Client client)
        {
            var a = _appointmentService.GetByClient(client);
            if (a == null)
                return NotFound();
            return Ok(a);
        }
        [HttpGet("{worker}")]
        public ActionResult Get([FromBody] Worker worker)
        {
            var a = _appointmentService.GetByWorker(worker);
            if (a == null)
                return NotFound();
            return Ok(a);
        }
        /* */
        /*//[HttpGet("{options}")]
        //public ActionResult Get( DateOnly? date, TimeOnly? time, [FromBody] Room? room)
        //{
        //    List<Appointment> ap = _context.Appointments;
        //    string s = "";
        //    if (date != null)
        //    {
        //        ap = ap.FindAll(a => a.Date.Equals(date));
        //        s += " date,";
        //    }
        //    if (time != null)
        //    {
        //        ap = ap.FindAll(a => a.Time.Equals(time));
        //        s += " time,";
        //    }
        //    if (room != null)
        //    {
        //        ap = ap.FindAll(a => a.Room.Equals(room));
        //        s += " room,";
        //    }
        //    if (ap.First() == null)
        //        return NotFound("did not found an object that fit in all" + s + "\b");
        //    Console.WriteLine("search of all this: " + s + "\b");
        //    return Ok(ap);
        //}*/

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] Appointment ap)
        {
            Task<bool> b = _appointmentService.Post(ap);
            if (b.IsCompletedSuccessfully)
                return Created("The object was successfully added", ap);
            return BadRequest("try again");
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment value)
        {
            Task<bool> b = _appointmentService.Put(id, value);
            if (b.IsCompletedSuccessfully)
                return Ok("The object has been successfully updated");
            else
                return NotFound("The object was not found or could not be updated");
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Task<bool> b = _appointmentService.Delete(id);
            if (b.IsCompletedSuccessfully)
                return Ok("The object has been successfully deleted");
            return NotFound("The object was not found or could not be deleted");
        }

    }
}
