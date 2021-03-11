using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Persistence.RepositoryManager;

namespace VDemyanov.BankApp.Persistence.Repository.AccountRepositoryJSON
{
    public class AccountRepositoryJSON : IAccountRepositoryJSON
    {
        private string pathToJSON = @"./../../../../Persistence/Data/AccountsForTestingAdapter.json";

        /// <summary>
        /// Добавление элемента во временную коллекцию и запись в этой коллекции в файл
        /// </summary>
        public List<Account> AddItemJSON(Account account, List<Account> accounts)
        { 
            Console.WriteLine("Добавление элемента JSON");
            if (!WasAccountFound(account, accounts))
            {
                accounts.Add(account);
                using (StreamWriter streamWriter = new StreamWriter(pathToJSON))
                {
                    string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                    streamWriter.Write(json);
                }
            }
            return accounts;
        }

        /// <summary>
        /// Инициализация репозитория
        /// </summary>
        public List<Account> InitRepositoryJSON()
        {
            Console.WriteLine("Инициализация репозитория JSON");

            List<Account> accounts = new List<Account>();

            using (StreamReader streamReader = new StreamReader(pathToJSON))
            {
                string test = streamReader.ReadToEnd();
                if (test != "" && test != null)
                {
                    accounts = JsonConvert.DeserializeObject<List<Account>>(test);
                }
            }

            return accounts;
        }

        private bool WasAccountFound(Account account, List<Account> accounts)
        {
            if (accounts.Any(acc => acc.AccountNumber == account.AccountNumber))
                return true;
            return false;
        }
    }
}
