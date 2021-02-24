using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Persistence.Enum;

namespace VDemyanov.BankApp.Persistence
{
    public class AccountsRepository : IGenericRepository<Account>
    {
        private string pathToJSON = @"./../../../Persistence/Data/Accounts.json";
        //private string pathToJSON = @"./../../../../Persistence/Data/Accounts.json";
        private List<Account> accounts;

        public AccountsRepository()
        {
            accounts = new List<Account>();
            FileInfo fileInfo = new FileInfo(pathToJSON);
            if (!fileInfo.Exists)
            {
                FileStream fs = new FileStream(pathToJSON, FileMode.Create);
                fs.Close();
            }

            using (StreamReader streamReader = new StreamReader(pathToJSON))
            {
                string test = streamReader.ReadToEnd();
                if (test != "" && test != null)
                {                    
                    this.accounts = JsonConvert.DeserializeObject<List<Account>>(test);
                }     
            }
        }

        public int GetAccountsLength()
        {
            return accounts.Count();
        }

        public void AddAccount(Account account)
        {
            if (!WasAccountFound(account))
            {
                this.accounts.Add(account);
                using (StreamWriter streamWriter = new StreamWriter(pathToJSON))
                {
                    string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                    streamWriter.Write(json);
                }
            }
        }

        private bool WasAccountFound(Account account)
        {
            if (this.accounts.Any(acc => acc.AccountNumber == account.AccountNumber))
                return true;
            return false;
        }

        static public List<Account> SortByAccountTypeAndOpeningDate(List<Account> result)
        {
            return result
                .OrderBy(acc => acc.AccountType)
                .ThenBy(acc => acc.OpeningDate).ToList();
        }

        public List<Account> SearchByOptions(SearchOptions searchOption, string option = "", int min = 0, int max = 0)
        {

            switch (searchOption)
            {
                case SearchOptions.FullName:
                    return accounts.Select(acc => acc).Where(acc => (acc.owner.LastName + " " + acc.owner.Name + " " + acc.owner.MiddleName) == option).ToList<Account>();
                    break;
                case SearchOptions.Balance:
                    return accounts.Select(acc => acc).Where(acc => (acc.Balance >= min && acc.Balance <= max)).ToList<Account>();
                    break;
                case SearchOptions.AccountNumber:
                    return accounts.Select(acc => acc).Where(acc => acc.AccountNumber == option).ToList<Account>();
                    break;
                case SearchOptions.AccountType:
                    return accounts.Select(acc => acc).Where(acc => acc.AccountType == option).ToList<Account>();
                    break;
                case SearchOptions.RegExpr:
                    return accounts.Select(acc => acc).Where(acc => Regex.IsMatch(acc.owner.Name, option + @"(\w*)", RegexOptions.IgnoreCase)).ToList<Account>();
                    break;
            }
            return new List<Account>();
        }
    }
}
