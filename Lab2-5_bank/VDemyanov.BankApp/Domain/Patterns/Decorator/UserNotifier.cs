using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns.Decorator
{
    public class UserNotifier : Notifier
    {
        public override void Send()
        {
            Console.WriteLine("Standart notifier");
        }
    }
}
