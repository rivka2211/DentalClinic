using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
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
        public List<Appointment> GetAll()
        {
            return _appointmentRepository.GetAll();
        }
        public IEnumerable<Appointment> GetByCode(int code)
        {
            return _appointmentRepository.GetByCode(code);
        }
        public IEnumerable<Appointment> GetByClient(Client client)
        {
            return _appointmentRepository.GetByClient(client);
        }
        public IEnumerable<Appointment> GetByWorker(Worker worker)
        {
            return _appointmentRepository.GetByWorker(worker);
        }


    }
}
