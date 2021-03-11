using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.RepositoryManager
{
    public class RepositoryManager
    {
        private List<Account> accounts;

        public RepositoryManager()
        {
            accounts = new List<Account>();
        }

        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        public void InitRepository(IAccountRepositoryJSON repository)
        {
            accounts = repository.InitRepositoryJSON();
        }

        /// <summary>
        /// Добавление элемента во временную коллекцию и запись этой коллекции в файл
        /// </summary>
        public void AddAccount(IAccountRepositoryJSON repository, Account account)
        {
            accounts = repository.AddItemJSON(account, this.accounts);
        }
    }
}
