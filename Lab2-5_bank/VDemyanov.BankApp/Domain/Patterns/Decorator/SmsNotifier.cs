using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns.Decorator
{
    public class SmsNotifier : NotifierDecoratorBase
    {
        public SmsNotifier(Notifier notifier) : base(notifier) { }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Notify user with sms");
        }
    }
}
