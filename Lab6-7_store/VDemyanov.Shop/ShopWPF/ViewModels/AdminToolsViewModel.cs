using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using VDemyanov.Shop.ShopWPF.Views.ViewServices;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class AdminToolsViewModel : ViewModelBase
    {
        private IMainWindowsCodeBehind _MainCodeBehind;

        #region Commands
        public ICommand CreateGuitarCommand { get; }
        //private void OnCreateGuitarCommandExecuted(object p) => ;
        private bool CanCreateGuitarCommandExecuted(object p) => true;
        #endregion

        public AdminToolsViewModel(IMainWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _MainCodeBehind = codeBehind;
        }
    }
}
