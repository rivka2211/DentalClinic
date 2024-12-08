using DentalClinic.API.Controllers;
using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Data.Repositories;
using DentalClinic.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalTest
{
    public class AppointmentControllerTest
    {
        private readonly AppointmentController _appointmentController;
        private readonly IDataContext fakeContext;
        public AppointmentControllerTest()
        {

            _appointmentController = new AppointmentController(new AppointmentService(new AppointmentRepository(fakeContext)));
        }

        [Fact]
        public void GetAll_ReturnsOK()
        {
            var result = _appointmentController.Get();
            Assert.IsType<List<Appointment>>(result);
        }

        [Fact]
        public void GetByCode_ReturnsOK()
        {
            var result = _appointmentController.Get(0);
            Assert.IsType<Ok>(result);
        }
        [Fact]
        public void GetByCode_NoteFound()
        {
            var result = _appointmentController.Get(23);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Post_ReturnsOK()
        {
            Worker worker = new Worker(1, "moshe", ProfessionsEnum.Orthodontist);
            DateOnly dateOnly = new DateOnly(2005, 12, 5);
            TimeOnly time = new TimeOnly(13, 55);
            Client client = new Client(12, "racheli", "akiva", MedicalInsuranceEnum.Macabi, dateOnly);
            Room room = new Room(2, 125, SuitableEnum.Dentist);

            Appointment appointment = new Appointment(dateOnly, time, worker, client, room);
            var result = _appointmentController.Get(4);
            Assert.IsType<Ok>(result);
        }
        [Fact]
        public void Delete_ReturensOk()
        {

        }
    }
}
