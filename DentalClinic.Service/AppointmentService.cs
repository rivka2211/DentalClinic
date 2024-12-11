using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public DbSet<Appointment> GetAll()
        {
            return _appointmentRepository.GetAll();
        }
        public IEnumerable<Appointment> GetByid(int id)
        {
            return _appointmentRepository.GetByid(id);
        }
        public IEnumerable<Appointment> GetByClient(Client client)
        {
            return _appointmentRepository.GetByClient(client);
        }
        public IEnumerable<Appointment> GetByWorker(Worker worker)
        {
            return _appointmentRepository.GetByWorker(worker);
        }
        public Task<bool> Post(Appointment appointment)
        {
            return _appointmentRepository.Post(appointment);
        }
        public Task<bool> Put(int id, Appointment appointment)
        {
            return _appointmentRepository.Put(id,appointment);
        }
        public Task<bool> Delete(int id)
        {
            return _appointmentRepository.Delete(id);
        }


    }
}
