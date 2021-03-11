using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns.Decorator
{
    public abstract class NotifierDecoratorBase : Notifier
    {
        protected Notifier notifier;

        public NotifierDecoratorBase(Notifier notifier)
        {
            this.notifier = notifier;
        }

        public override void Send()
        {
            notifier.Send();
        }

    }
}
