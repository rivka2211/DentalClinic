﻿using DentalClinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Services
{
    public interface IWorkerService
    {
         List<Worker> GetAll();
    }
}
