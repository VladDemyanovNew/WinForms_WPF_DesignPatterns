using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Persons
{
    public class Owner
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string MiddleName { get; protected set; }
        public DateTime Birthday { get; protected set; }
        public string PassportData { get; protected set; }

        public Owner(string name, string lastName, string middleName, DateTime birthday, string passportData)
        {
            this.Name = name;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Birthday = birthday;
            this.PassportData = passportData;
        }

        public override string ToString()
        {
            return this.Name + " " + this.LastName + " " + this.MiddleName + " " + this.Birthday + " " + this.PassportData;
        }
    }
}
