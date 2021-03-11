using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Domain.Patterns.Decorator
{
    public abstract class Notifier
    {
        public abstract void Send();
    }
}
