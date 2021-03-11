using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;


// Abstract Factory
namespace VDemyanov.BankApp.Domain
{
    public abstract class Operation
    {
        public abstract void ToPerformOperation();
    }

    class DebitCardOperation : Operation
    {
        public override void ToPerformOperation()
        {
            Console.WriteLine("Произведена операция с дебетовой картой!");
        }
    }

    class CreditCardOperation : Operation
    {
        public override void ToPerformOperation()
        {
            Console.WriteLine("Произведена операция с кредитной картой!");
        }
    }

    public abstract class CardFactory
    {
        private protected Account account;
        private protected Owner owner;

        public CardFactory(Account account, Owner owner)
        {
            this.account = account;
            this.owner = owner;
        }

        public abstract Operation CreateOperation();
        public abstract Account BrokerageAccount();
        public abstract Owner BrokerageOwner();
    }

    public class DebitCardFactory : CardFactory
    {
        public DebitCardFactory(Account account, Owner owner)
            : base(account, owner) { }

        public override Account BrokerageAccount()
        {
            return this.account;
        }

        public override Owner BrokerageOwner()
        {
            return this.owner;
        }

        public override Operation CreateOperation()
        {
            return new DebitCardOperation();
        }
    }

    public class CreditCardFactory : CardFactory
    {
        public CreditCardFactory(Account account, Owner owner) 
            : base(account, owner) { }


        public override Account BrokerageAccount()
        {
            return this.account;
        }
        public override Owner BrokerageOwner()
        {
            return this.owner;
        }
        public override Operation CreateOperation()
        {
            return new CreditCardOperation();
        }
    }
}
