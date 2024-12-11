using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Services
{
    public interface IRoomService
    {
        DbSet<Room> GetAll();

        IEnumerable<Room> GetById(int Id);
        IEnumerable<Room> GetBySuitable(SuitableEnum suitable);
        Task<bool> Post(Room room);
        Task<bool> Put(int Id, Room room);
        Task<bool> Delete(int Id);
    }
}
