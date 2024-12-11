using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;


namespace DentalClinic.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IDataContext _context;

        public RoomRepository(IDataContext context)
        {
            _context = context;
        }

        public DbSet<Room> GetAll()
        {
            return _context.Rooms;
        }

        public IEnumerable<Room> GetById(int id)
        {
            Room room = _context.Rooms.ToList().Find(r => r.Id == id);
            yield return room;
        }
        public IEnumerable<Room> GetBySuitable(SuitableEnum suitable)
        {
            return _context.Rooms.Where(a => a.Suitable == suitable).ToList();
        }
        public async Task<bool> Post(Room room)
        {
            try
            {
                await _context.Rooms.AddAsync(room); // הוספת המינוי
                                                     // await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public async Task<bool> Put(int id, Room value)
        {
            try
            {
                var room = _context.Rooms.Where(c => c.Id == id).First();
                if (room == null)
                    return false;
                if (room.Equals(value))
                    return true;
                room.Number = value.Number;
                room.Floor = value.Floor;
                room.Suitable = value.Suitable;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var room = _context.Rooms.Where(c => c.Id == id).First();
                _context.Rooms.Remove(room);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
