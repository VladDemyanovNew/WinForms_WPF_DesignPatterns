using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.Repository.AccountRepositoryXML
{
    public interface IAccountRepositoryXML
    {
        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        List<Account> InitRepositoryXML();

        /// <summary>
        /// Добавление элемента во временную коллекцию и запись в этой коллекции в файл
        /// </summary>
        List<Account> AddItemXML(Account account, List<Account> accounts);
    }
}
