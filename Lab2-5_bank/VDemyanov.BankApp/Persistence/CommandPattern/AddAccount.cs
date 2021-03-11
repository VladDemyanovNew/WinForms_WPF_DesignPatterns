using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.CommandPattern
{
    /// <summary>
    /// Конкретная реализация команды
    /// </summary>
    public class AddAccount : Command
    {
        private Account _account;
        public AddAccount(AccountsRepository accountsRepository, Account account) : base(accountsRepository) 
        {
            _account = account;
        }

        public override void Excecute()
        {
            _accountsRepository.AddAccount(_account);
            Console.WriteLine("Операция создания счёта...");
        }

        public override void Undo()
        {
            _accountsRepository.DeleteAccount(_account.AccountNumber);
            Console.WriteLine("Отмена операции создания счёта...");
        }
    }
}
