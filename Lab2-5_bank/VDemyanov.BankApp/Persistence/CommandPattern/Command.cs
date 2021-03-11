using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.CommandPattern
{

    /// <summary>
    /// Интерфейс, представляющий команду
    /// </summary>
    public abstract class Command
    {
        protected AccountsRepository _accountsRepository;
        public abstract void Excecute();
        public abstract void Undo();
        public Command(AccountsRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }
    }
}
