using NUnit.Framework;
using System;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Domain.Persons;
using VDemyanov.BankApp.Persistence;

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
    }
}