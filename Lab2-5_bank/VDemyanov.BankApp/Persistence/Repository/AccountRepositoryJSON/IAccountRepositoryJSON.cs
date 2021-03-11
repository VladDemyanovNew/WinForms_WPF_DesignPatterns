using System;
using System.Collections.Generic;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.RepositoryManager
{
    public interface IAccountRepositoryJSON
    {
        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        List<Account> InitRepositoryJSON();


        /// <summary>
        /// Добавление элемента во временную коллекцию и запись в этой коллекции в файл
        /// </summary>
        List<Account> AddItemJSON(Account account, List<Account> accounts);

    }
}
