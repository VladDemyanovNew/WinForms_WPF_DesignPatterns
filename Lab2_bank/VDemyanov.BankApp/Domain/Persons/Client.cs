using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Persons
{
    public class Client : Owner
    {
        public Client(string name, string lastName, string middleName, DateTime birthday, string passportData)
        {
            this.name = name;
            this.lastName = lastName;
            this.middleName = middleName;
            this.birthday = birthday;
            this.passportData = passportData;
        }

        public override string ToString()
        {
            return this.name + " " + this.lastName + " " + this.middleName + " " + this.birthday + " " + this.passportData;
        }
    }
}
