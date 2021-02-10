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
                new Client("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "passport"));
            Console.WriteLine(account.ToString());
            Assert.Pass();
        }

        [Test]
        public void TestCreatingAccountsFile()
        {
            AccountsRepository accountsRepository = new AccountsRepository();
            Assert.Pass();
        }

        [Test]
        public void TestCreatingClientsFile()
        {
            ClientsRepository accountsRepository = new ClientsRepository();
            Assert.Pass();
        }
    }
}