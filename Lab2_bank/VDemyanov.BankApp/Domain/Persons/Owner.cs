using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Persons
{
    public abstract class Owner
    {
        private protected string name;
        private protected string lastName;
        private protected string middleName;
        private protected DateTime birthday;
        private protected string passportData;
    }
}
