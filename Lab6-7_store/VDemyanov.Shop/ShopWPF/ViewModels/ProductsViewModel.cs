using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using VDemyanov.Shop.ShopWPF.Data;
using VDemyanov.Shop.ShopWPF.Models;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using VDemyanov.Shop.ShopWPF.Views.ViewInfrastructure;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class ProductsViewModel : ViewModelBase
    {
        
        private IMainWindowsCodeBehind _MainCodeBehind;

        #region GuitarSearchText
        private string _GuitarSearchText;
        public string GuitarSearchText
        {
            get => _GuitarSearchText;
            set
            {
                if(!Set(ref _GuitarSearchText, value)) return;
                _SelectedGuitars.View.Refresh();
            }
        }
        #endregion

        #region Guitars
        private ObservableCollection<Guitar> _Guitars;
        public ObservableCollection<Guitar> Guitars
        {
            get => _Guitars;
            set
            {
                if (!Set(ref _Guitars, value)) return;
                _SelectedGuitars.Source = value;
                OnPropertyChanged(nameof(SelectedGuitars));
            }
        }
        #endregion

        #region GuitarsView
        private readonly CollectionViewSource _SelectedGuitars = new CollectionViewSource();
        public ICollectionView SelectedGuitars => _SelectedGuitars?.View;
        #endregion

        /// <summary>
        /// Обработчик поиска гитары
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGuitarSearched(object sender, FilterEventArgs e)
        {
            if(!(e.Item is Guitar guitar))
            {
                e.Accepted = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(_GuitarSearchText))
                return;

            if (guitar.Title is null || guitar.Category is null || guitar.Brand is null)
            {
                e.Accepted = false;
                return;
            }

            var search_text = _GuitarSearchText.ToLower();
            string title = guitar.Title.ToLower();
            string category = guitar.Category.ToLower();
            string brand = guitar.Brand.ToLower();

            if (title.Contains(search_text)) return;
            if (category.Contains(search_text)) return;
            if (brand.Contains(search_text)) return;

            e.Accepted = false;
        }

        public ProductsViewModel(IMainWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _MainCodeBehind = codeBehind;

            Guitars = new GuitarRepository().GetGuitars();
            _SelectedGuitars.Filter += OnGuitarSearched;
        }

    }
}
