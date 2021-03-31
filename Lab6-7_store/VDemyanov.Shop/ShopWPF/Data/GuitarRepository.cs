using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDemyanov.Shop.ShopWPF.Models;

namespace VDemyanov.Shop.ShopWPF.Data
{
    internal class GuitarRepository
    {
        private ObservableCollection<Guitar> _Guitars;

        public GuitarRepository()
        {
            _Guitars = new ObservableCollection<Guitar>
            {
                new Guitar(1, "Title1", 300, "Category1", "Brand1", @"/Images/Guitar1.jpg"),
                new Guitar(2, "Title2", 150, "Category2", "Brand2", @"/Images/Guitar2.jpg"),
                new Guitar(3, "Title3", 600, "Category3", "Brand3", @"/Images/Guitar3.jpg"),
                new Guitar(4, "Title4", 210, "Category4", "Brand4", @"/Images/Guitar4.jpg"),
                new Guitar(5, "Title5", 450, "Category5", "Brand5", @"/Images/Guitar5.jpg")
            };
        }

        public ObservableCollection<Guitar> GetGuitars()
        {
            return _Guitars;
        }
    }
}
