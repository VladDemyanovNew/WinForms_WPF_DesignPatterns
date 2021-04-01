using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDemyanov.Shop.ShopWPF.Models;

namespace VDemyanov.Shop.ShopWPF.Data
{
    internal class GuitarRepository
    {
        private string pathToJSON = @"./../../Data/Files/Guitars.json";
        private ObservableCollection<Guitar> _Guitars;

        public GuitarRepository()
        {

            _Guitars = new ObservableCollection<Guitar>();

            FileInfo fileInfo = new FileInfo(pathToJSON);
            if (!fileInfo.Exists)
            {
                using (FileStream fs = new FileStream(pathToJSON, FileMode.Create)) { };
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(pathToJSON, true))
                {
                    string data = streamReader.ReadToEnd();
                    if (data != "" && data != null)
                    {
                        this._Guitars = JsonConvert.DeserializeObject<ObservableCollection<Guitar>>(data);
                    }
                }
            }
        }

        /// <summary>
        /// Записывает коллекции гитар в файл JSON
        /// </summary>
        private void WriteAccountsInJSON()
        {
            using (StreamWriter streamWriter = new StreamWriter(pathToJSON))
            {
                string json = JsonConvert.SerializeObject(_Guitars, Formatting.Indented);
                streamWriter.Write(json);
            }
        }

        /// <summary>
        /// Добавляет гитары в коллекцию и записывает коллекции в json файл
        /// </summary>
        /// <param name="guitar"></param>
        public void Add(Guitar guitar)
        {
            _Guitars.Add(guitar);
            WriteAccountsInJSON();
        }

        /// <summary>
        /// Возвращает коллекцию гитар
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Guitar> GetGuitars()
        {
            return _Guitars;
        }
    }
}
