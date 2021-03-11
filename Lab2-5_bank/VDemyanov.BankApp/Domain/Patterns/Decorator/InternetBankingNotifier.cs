using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns.Decorator
{
    public class InternetBankingNotifier : NotifierDecoratorBase
    {
        public InternetBankingNotifier(Notifier notifier) : base(notifier) { }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Notify user with internet banking");
        }
    }
}
