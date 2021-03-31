using ShopWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VDemyanov.Shop.ShopWPF.Data;
using VDemyanov.Shop.ShopWPF.Infrastructure.Commands;
using VDemyanov.Shop.ShopWPF.Models;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using static System.Net.Mime.MediaTypeNames;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) => App.Current.Shutdown();
        private bool CanCloseApplicationCommandExecuted(object p) => true;
        #endregion

        

        #endregion


        private ObservableCollection<Guitar> _Guitars;
        public ObservableCollection<Guitar> Guitars
        {
            get => _Guitars;
            set => Set(ref _Guitars, value);
        }

        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
            #endregion

            _Guitars = new GuitarRepository().GetGuitars();
        }

    }
}
