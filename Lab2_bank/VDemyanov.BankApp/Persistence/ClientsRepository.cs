using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VDemyanov.BankApp.Domain.Persons;

namespace VDemyanov.BankApp.Persistence
{
    public class ClientsRepository : IGenericRepository<Owner>
    {
        private string pathToJSON = @"./../../../../Persistence/Data/Clients.json";
        private List<Owner> owners;

        public ClientsRepository()
        {
            FileInfo fileInfo = new FileInfo(pathToJSON);
            if (!fileInfo.Exists)
            {
                FileStream fs = new FileStream(pathToJSON, FileMode.Create);
                fs.Close();
            }

            using (StreamReader streamReader = new StreamReader(pathToJSON))
            {
                this.owners = JsonConvert.DeserializeObject<List<Owner>>(streamReader.ReadToEnd());
            }
        }
    }


}
