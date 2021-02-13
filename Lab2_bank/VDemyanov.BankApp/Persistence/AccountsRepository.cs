using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence
{
    public class AccountsRepository : IGenericRepository<Account>
    {
        public string pathToJSON = @"./../../../Persistence/Data/Accounts.json";
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
    }
}
