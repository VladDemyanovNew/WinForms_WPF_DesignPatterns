using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence.Repository.AccountRepositoryXML
{
    public class AccountRepositoryXML : IAccountRepositoryXML
    {
        private string pathToXML = @"./../../../../Persistence/Data/AccountsForTestingAdapter.xml";
        public List<Account> AddItemXML(Account account, List<Account> accounts)
        {
            Console.WriteLine("Добавление элемента XML");
            XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

            if (!WasAccountFound(account, accounts))
            {
                accounts.Add(account);
                using (StreamWriter streamWriter = new StreamWriter(pathToXML))
                {
                    formatter.Serialize(streamWriter, accounts);
                }
            }
            return accounts;
        }

        public List<Account> InitRepositoryXML()
        {
            Console.WriteLine("Инициализация репозитория XML");

            List<Account> accounts = new List<Account>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

            using (StreamReader streamReader = new StreamReader(pathToXML))
            {
                if (streamReader.ReadLine() != null)
                    accounts = (List<Account>)formatter.Deserialize(streamReader);
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
