using NUnit.Framework;
using System;
using System.Collections.Generic;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Domain.Patterns;
using VDemyanov.BankApp.Domain.Patterns.Decorator;
using VDemyanov.BankApp.Domain.Persons;
using VDemyanov.BankApp.Persistence;
using VDemyanov.BankApp.Persistence.CommandPattern;
using VDemyanov.BankApp.Persistence.Enum;
using VDemyanov.BankApp.Persistence.Repository.AccountRepositoryJSON;
using VDemyanov.BankApp.Persistence.Repository.AccountRepositoryXML;
using VDemyanov.BankApp.Persistence.RepositoryManager;

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
    
        [Test]
        public void TestAbstaractFactoryAndBuilder()
        {
            
            Owner owner = new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "GH92OL88II99PP");
            Account account = new Account("7k", "валютный счёт", 2000, DateTime.Now, true, false, owner);

            CardDesigner cardDesigner = new CardDesigner();
            CardBuilder cardBuilder = new CreditCardBuilder(new CreditCardFactory(account, owner));

            Card creditCard = cardDesigner.ReleaseCard(cardBuilder);

            Console.WriteLine(creditCard.ToString());
            creditCard.ToPerformOperation();

            Assert.Pass();
        }

        [Test]
        public void TestPrototype()
        {
            IOwner owner = new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "GH92OL88II99PP");
            IOwner clonedOwner = owner.Clone();
            Console.WriteLine("оригинал: " + owner.GetInfo());
            Console.WriteLine("клон: " + clonedOwner.GetInfo());
        }

        [Test]
        public void TestAdapter()
        {
            Owner owner = new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "GH92OL88II99PP");
            Account account = new Account("7k", "валютный счёт", 2000, DateTime.Now, true, false, owner);

            Account account2 = new Account("8k", "расчётный счёт", 3000, DateTime.Now, true, false, owner);

            RepositoryManager repositoryManager = new RepositoryManager();
            AccountRepositoryJSON accountRepositoryJSON = new AccountRepositoryJSON();

            //repositoryManager.InitRepository(accountRepositoryJSON);
            //repositoryManager.AddAccount(accountRepositoryJSON, account);
            //repositoryManager.AddAccount(accountRepositoryJSON, account2);

            AccountRepositoryXML accountRepositoryXML = new AccountRepositoryXML();
            IAccountRepositoryJSON test = new AccountRepositoryXmlToJsonAdapter(accountRepositoryXML);
            
            repositoryManager.InitRepository(test);
            repositoryManager.AddAccount(test, account);
            //repositoryManager.AddAccount(test, account2);
        }

        [Test]
        public void TestDecorator()
        {
            Notifier notifier = new UserNotifier();

            notifier = new SmsNotifier(notifier);
            notifier.Send();
            Console.WriteLine("\n");
            notifier = new InternetBankingNotifier(notifier);
            notifier.Send();
        }

        [Test]
        public void TestCommand()
        {
            AccountsRepository accountsRepository = new AccountsRepository();
            Owner owner = new Owner("Vlad", "Demyanov", "Ruslanovich", DateTime.Now, "GH92OL88II99PP");
            Account account = new Account("7k", "валютный счёт", 2000, DateTime.Now, true, false, owner);

            Invoker invoker = new Invoker();

            invoker.Command = new AddAccount(accountsRepository, account);
            invoker.Run();
            //invoker.Undo();

            invoker.Command = new DeleteAccount(accountsRepository, "7k");
            invoker.Run();
            invoker.Undo();
        }
    }
}