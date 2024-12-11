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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public DbSet<Room> GetAll()
        {
            return _roomRepository.GetAll();
        }

        public IEnumerable<Room> GetById(int Id)
        {
            return _roomRepository.GetById(Id);
        }
        public IEnumerable<Room> GetBySuitable(SuitableEnum suitable)
        {
            return _roomRepository.GetBySuitable(suitable);
        }
        public Task<bool> Post(Room room)
        {
            return _roomRepository.Post(room);
        }
        public Task<bool> Put(int Id, Room room)
        {
            return _roomRepository.Put(Id, room);
        }
        public Task<bool> Delete(int Id)
        {
            return _roomRepository.Delete(Id);
        }
    }
}
