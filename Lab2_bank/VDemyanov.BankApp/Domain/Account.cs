using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;

namespace VDemyanov.BankApp.Domain
{
    public class Account
    {
        Owner owner;
        private string accountNumber;
        private string accountType;
        private decimal balance;
        private DateTime openingDate;
        private bool InternetBanking;
        private bool SMS_alert;

        public Account(
            string accountNumber,
            string accountType,
            decimal balance,
            DateTime openingDate,
            bool InternetBanking,
            bool SMS_alert,
            Owner owner)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = balance;
            this.openingDate = openingDate;
            this.InternetBanking = InternetBanking;
            this.SMS_alert = SMS_alert;
            this.owner = owner;
        }

        public override string ToString()
        {
            return base.ToString() + " " +
                this.accountNumber + " " +
                this.accountType + " " +
                this.balance + " " +
                this.openingDate + " " +
                this.InternetBanking + " " +
                this.SMS_alert + " " +
                owner.ToString();
        }
    }
}
