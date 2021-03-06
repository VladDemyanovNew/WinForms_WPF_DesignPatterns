﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;

namespace VDemyanov.BankApp.Domain
{
    [Serializable]
    public class Account
    {
        public Owner owner;
        public string AccountNumber { get; }
        [Required(ErrorMessage ="Тип счёта не установлен")]
        public string AccountType { get; }
        public decimal Balance { get; }
        [Required(ErrorMessage = "Дата открытия счёта не установлена")]
        public DateTime OpeningDate { get; }
        [Required(ErrorMessage = "Наличие интернет-банкинга не установлено")]
        public bool InternetBanking { get; }
        [Required(ErrorMessage = "Наличие смс уведомления")]
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

        private Account() { }

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
