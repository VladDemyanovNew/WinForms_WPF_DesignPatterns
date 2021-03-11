using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;

namespace VDemyanov.BankApp.Domain
{
    /// <summary>
    /// Справка о доходах
    /// </summary>
    public class IncomeCertificate
    {

    }
    /// <summary>
    /// Трудовая книжка
    /// </summary>
    public class Workbook
    {

    }

    public class Card
    {
        private Account account;
        private Owner owner;
        private Operation operation;
        public IncomeCertificate IncomeCertificate { get; set; }
        public Workbook Workbook { get; set; }

        public Card(CardFactory cardFactory)
        {
            this.operation = cardFactory.CreateOperation();
            this.account = cardFactory.BrokerageAccount();
            this.owner = cardFactory.BrokerageOwner();
        }

        public void ToPerformOperation()
        {
            this.operation.ToPerformOperation();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (IncomeCertificate != null)
                sb.Append("Справка о доходах \n");
            if (Workbook != null)
                sb.Append("Трудовая книжка \n");
            return sb.ToString();
        }
    }
}
