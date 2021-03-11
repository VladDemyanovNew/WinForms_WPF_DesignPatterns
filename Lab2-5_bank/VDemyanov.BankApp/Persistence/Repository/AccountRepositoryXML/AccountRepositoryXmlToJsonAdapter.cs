using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Persistence.RepositoryManager;

namespace VDemyanov.BankApp.Persistence.Repository.AccountRepositoryXML
{
    public class AccountRepositoryXmlToJsonAdapter : IAccountRepositoryJSON
    {
        AccountRepositoryXML accountRepositoryXML;
        public AccountRepositoryXmlToJsonAdapter(AccountRepositoryXML repositoryXML)
        {
            accountRepositoryXML = repositoryXML;
        }

        /// <summary>
        /// Добавление элемента во временную коллекцию и запись в этой коллекции в файл
        /// </summary>
        public List<Account> AddItemJSON(Account account, List<Account> accounts)
        {
            return accountRepositoryXML.AddItemXML(account, accounts);
        }

        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        public List<Account> InitRepositoryJSON()
        {
            return accountRepositoryXML.InitRepositoryXML();
        }
    }
}
