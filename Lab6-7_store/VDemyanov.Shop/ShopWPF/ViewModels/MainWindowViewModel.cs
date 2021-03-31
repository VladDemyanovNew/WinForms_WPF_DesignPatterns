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
using VDemyanov.Shop.ShopWPF.Views.ViewServices;
using static System.Net.Mime.MediaTypeNames;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Properties
        public IMainWindowsCodeBehind CodeBehind { get; set; }

        #region Guitars
        private ObservableCollection<Guitar> _Guitars;
        public ObservableCollection<Guitar> Guitars
        {
            get => _Guitars;
            set => Set(ref _Guitars, value);
        }
        #endregion

        #endregion

        #region Commands

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) => App.Current.Shutdown();
        private bool CanCloseApplicationCommandExecuted(object p) => true;
        #endregion

        #region LoadAdminToolsCommand
        public ICommand LoadAdminToolsCommand { get; }
        private void OnLoadAdminToolsCommandExecuted(object p) => CodeBehind.LoadView(ViewType.ADMIN_TOOLS);
        private bool CanLoadAdminToolsCommandExecuted(object p) => true;
        #endregion

        #region LoadProductsCommand
        public ICommand LoadProductsCommand { get; }
        private void OnLoadProductsCommandExecuted(object p) => CodeBehind.LoadView(ViewType.PRODUCTS);
        private bool CanLoadProductsCommandExecuted(object p) => true;
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Commands
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
            LoadAdminToolsCommand = new RelayCommand(OnLoadAdminToolsCommandExecuted, CanLoadAdminToolsCommandExecuted);
            LoadProductsCommand = new RelayCommand(OnLoadProductsCommandExecuted, CanLoadProductsCommandExecuted);
            #endregion

            #region Properties
            _Guitars = new GuitarRepository().GetGuitars();
            #endregion
        }

    }
}
