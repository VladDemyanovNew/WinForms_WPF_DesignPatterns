using Lab10.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.MaintenanceServices.Domain.Models.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
