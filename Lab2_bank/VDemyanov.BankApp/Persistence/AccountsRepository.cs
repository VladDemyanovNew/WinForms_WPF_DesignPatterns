using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VDemyanov.BankApp.Domain;

namespace VDemyanov.BankApp.Persistence
{
    public class AccountsRepository : IGenericRepository<Account>
    {
        private string pathToJSON = @"./../../../../Persistence/Data/Accounts.json";
        private List<Account> accounts;

        public AccountsRepository()
        {
            FileInfo fileInfo = new FileInfo(pathToJSON);
            if (!fileInfo.Exists)
            {
                FileStream fs = new FileStream(pathToJSON, FileMode.Create);
                fs.Close();
            }

            using (StreamReader streamReader = new StreamReader(pathToJSON))
            {
                this.accounts = JsonConvert.DeserializeObject<List<Account>>(streamReader.ReadToEnd());
            }
        }
    }
}
