using DentalClinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Repositories
{
    public interface IWorkerRepository
    {
        List<Worker> GetAll();

    }
}
