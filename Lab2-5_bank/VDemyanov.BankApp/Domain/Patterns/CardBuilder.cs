using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns
{
    public abstract class CardBuilder
    {
        public Card Card { get; private set; }
        private CardFactory cardFactory;

        public CardBuilder(CardFactory cardFactory)
        {
            this.cardFactory = cardFactory;
        }

        public void CreateCard()
        {
            Card = new Card(this.cardFactory);
        }

        public abstract void SetIncomeCertificate();
        public abstract void SetWorkbook();
    }

    public class CardDesigner // распорядитель
    {
        public Card ReleaseCard(CardBuilder cardBuilder)
        {
            cardBuilder.CreateCard();
            cardBuilder.SetIncomeCertificate();
            cardBuilder.SetWorkbook();
            return cardBuilder.Card;
        }
    }

    public class CreditCardBuilder : CardBuilder // конкретная реализация Builder
    {
        public CreditCardBuilder(CreditCardFactory cardFactory) : base(cardFactory) { }
        public override void SetIncomeCertificate()
        {
            this.Card.IncomeCertificate = new IncomeCertificate();
        }

        public override void SetWorkbook()
        {
            this.Card.Workbook = new Workbook();
        }
    }

    public class DebitCardBuilder : CardBuilder // конкретная реализация Builder
    {
        public DebitCardBuilder(DebitCardFactory cardFactory) : base(cardFactory) { }
        public override void SetIncomeCertificate()
        {
            
        }

        public override void SetWorkbook()
        {
            this.Card.Workbook = new Workbook();
        }
    }
}
