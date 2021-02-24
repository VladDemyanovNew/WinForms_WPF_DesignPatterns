using NUnit.Framework;
using System;
using System.Collections.Generic;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Domain.Persons;
using VDemyanov.BankApp.Persistence;
using VDemyanov.BankApp.Persistence.Enum;

namespace NUnitTestBankApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreatingAccount()
        {
            Account account = new Account(
                "123k", "someType", 234, DateTime.Now, true, false,
                new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "passport"));
            Console.WriteLine(account.ToString());
            Assert.Pass();
        }

        [Test]
        public void TestCreatingAccountsFile()
        {
            Account account = new Account(
                "123k", "someType", 234, DateTime.Now, true, false,
                new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "passport"));

            Account account2 = new Account(
                "124k", "someType", 234, DateTime.Now, true, false,
                new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "passport"));

            AccountsRepository accountsRepository = new AccountsRepository();
            accountsRepository.AddAccount(account);
            accountsRepository.AddAccount(account2);
            Assert.Pass();
        }

        [Test]
        public void TestSearching()
        {
            AccountsRepository accountsRepository = new AccountsRepository();
            List<Account> accounts = accountsRepository.SearchByOptions(SearchOptions.RegExpr, "вл");
            accounts = AccountsRepository.SortByAccountTypeAndOpeningDate(accounts);
            if (accounts.Count == 0)
                Console.WriteLine("Ничего не найдено");
            else
                foreach (Account acc in accounts)
                    Console.WriteLine(acc.ToString());
            Assert.Pass();
        }
    }
}