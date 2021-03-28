using ShopWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VDemyanov.Shop.ShopWPF.Infrastructure.Commands;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using static System.Net.Mime.MediaTypeNames;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Заголовок окна
        private string _Title = "Test";

        /// <summary>Заголовок ока</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            App.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecuted(object p) => true;
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
            #endregion
        }
    }
}
