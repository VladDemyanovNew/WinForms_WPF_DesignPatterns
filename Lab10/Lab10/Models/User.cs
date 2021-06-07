using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.MaintenanceServices.Domain.Models.Base;

namespace Lab10.Models
{
    public class User : Entity
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + ": Age=" + Age.ToString() + " Name=" + Name;
        }
    }
}
