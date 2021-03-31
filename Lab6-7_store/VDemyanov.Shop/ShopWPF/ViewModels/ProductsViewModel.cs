using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDemyanov.Shop.ShopWPF.Data;
using VDemyanov.Shop.ShopWPF.Models;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using VDemyanov.Shop.ShopWPF.Views.ViewServices;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class ProductsViewModel : ViewModelBase
    {
        
        private IMainWindowsCodeBehind _MainCodeBehind;


        #region Guitars
        private ObservableCollection<Guitar> _Guitars;
        public ObservableCollection<Guitar> Guitars
        {
            get => _Guitars;
            set => Set(ref _Guitars, value);
        }
        #endregion

        public ProductsViewModel(IMainWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _MainCodeBehind = codeBehind;

            _Guitars = new GuitarRepository().GetGuitars();
        }
    }
}
