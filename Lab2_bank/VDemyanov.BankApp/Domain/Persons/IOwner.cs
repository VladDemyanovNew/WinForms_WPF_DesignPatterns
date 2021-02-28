using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Persons
{
    public interface IOwner
    {
        IOwner Clone();
        string GetInfo();
    }
}
