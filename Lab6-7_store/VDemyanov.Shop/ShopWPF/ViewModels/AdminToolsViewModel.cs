using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VDemyanov.Shop.ShopWPF.Data;
using VDemyanov.Shop.ShopWPF.Infrastructure.Commands;
using VDemyanov.Shop.ShopWPF.Models;
using VDemyanov.Shop.ShopWPF.ViewModels.Base;
using VDemyanov.Shop.ShopWPF.Views.ViewInfrastructure;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class AdminToolsViewModel : ViewModelBase
    {

        #region Propeties
        private IMainWindowsCodeBehind _MainCodeBehind;

        #region GuitarRepository
        private GuitarRepository _GuitarRepository;
        public GuitarRepository GuitarRepositoryProp
        {
            get => _GuitarRepository;
            set => Set(ref _GuitarRepository, value);
        }
        #endregion

        #region Guitar
        private Guitar _Guitar;
        public Guitar GuitarProp
        {
            get => _Guitar;
            set => Set(ref _Guitar, value);
        }
        #endregion

        #endregion

        #region Commands
        public ICommand CreateGuitarCommand { get; }
        private void OnCreateGuitarCommandExecuted(object p)
        {
            int id = _GuitarRepository.GetGuitars().Count() + 1;
            _Guitar.Id = id;
            _GuitarRepository.Add(_Guitar);
            _Guitar = new Guitar();
        }
        private bool CanCreateGuitarCommandExecuted(object p) => true;
        #endregion

        public AdminToolsViewModel(IMainWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            #region Commands
            CreateGuitarCommand = new RelayCommand(OnCreateGuitarCommandExecuted, CanCreateGuitarCommandExecuted);
            #endregion
            
            #region Properties
            _MainCodeBehind = codeBehind;
            _GuitarRepository = new GuitarRepository();
            _Guitar = new Guitar();
            #endregion
        }
    }
}
