using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Persons
{
    class SpecialOwner : IOwner
    {
        public IOwner Clone()
        {
            return new SpecialOwner();
        }

        public string GetInfo()
        {
            return "Я бесполезный экземпляр класса!";
        }
    }
}
