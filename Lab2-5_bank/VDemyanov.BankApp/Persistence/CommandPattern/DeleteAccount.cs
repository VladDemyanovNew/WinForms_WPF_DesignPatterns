using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.CommandPattern
{
    /// <summary>
    /// Конкретная реализация команды
    /// </summary>
    public class DeleteAccount : Command
    {
        private string _accountNumber;
        private Account _backup;
        public DeleteAccount(AccountsRepository accountsRepository, string accountNumber) : base(accountsRepository)
        {
            _accountNumber = accountNumber;
            foreach (var acc in accountsRepository.Accounts)
            {
                if (acc.AccountNumber == accountNumber)
                    _backup = acc;
            }
        }

        public override void Excecute()
        {
            _accountsRepository.DeleteAccount(_accountNumber);
            Console.WriteLine("Операция удаления счёта...");
        }

        public override void Undo()
        {
            if (_backup != null)
                _accountsRepository.AddAccount(_backup);
            else
                throw new Exception("public class DeleteAccount: не инициализирована private Account _backup");
            Console.WriteLine("Отмена операции удаления счёта...");
        }
    }
}
