using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;

namespace VDemyanov.BankApp.Domain
{
    public class Account
    {
        public Owner owner;
        public string AccountNumber { get; }
        public string AccountType { get; }
        public decimal Balance { get; }
        public DateTime OpeningDate { get; }
        public bool InternetBanking { get; }
        public bool SMS_alert { get; }

        public Account(
            string accountNumber,
            string accountType,
            decimal balance,
            DateTime openingDate,
            bool InternetBanking,
            bool SMS_alert,
            Owner owner)
        {
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.Balance = balance;
            this.OpeningDate = openingDate;
            this.InternetBanking = InternetBanking;
            this.SMS_alert = SMS_alert;
            this.owner = owner;
        }

        public override string ToString()
        {
            return base.ToString() + " " +
                this.AccountNumber + " " +
                this.AccountType + " " +
                this.Balance + " " +
                this.OpeningDate + " " +
                this.InternetBanking + " " +
                this.SMS_alert + " " +
                owner.ToString();
        }
    }
}
