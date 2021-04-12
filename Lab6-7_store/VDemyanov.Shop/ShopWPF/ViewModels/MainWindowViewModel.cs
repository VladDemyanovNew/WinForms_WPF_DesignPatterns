using ShopWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using VDemyanov.Shop.ShopWPF.Views.ViewInfrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace VDemyanov.Shop.ShopWPF.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public IMainWindowsCodeBehind CodeBehind { get; set; }

        private string _CurrentLanguage;

        private List<string> _Styles;
        private string _CurrentStyle;

        #region Commands

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) => App.Current.Shutdown();
        private bool CanCloseApplicationCommandExecuted(object p) => true;
        #endregion

        #region ChangeThemeCommand
        public ICommand ChangeThemeCommand { get; }
        private void OnChangeThemeCommandExecuted(object p)
        {
            switch (_CurrentStyle)
            {
                case "light":
                    ChangeTheme("Resources/Themes/dark.xaml", "dark");
                    break;
                case "dark":
                    ChangeTheme("Resources/Themes/light.xaml", "light");
                    break;
            }
        }
        private bool CanChangeThemeCommandExecuted(object p) => true;
        private void ChangeTheme(string src, string theme)
        {
            // определяем путь к файлу ресурсов
            var uri1 = new Uri(src, UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict1 = App.LoadComponent(uri1) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            App.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            App.Current.Resources.MergedDictionaries.Add(resourceDict1);
            _CurrentStyle = theme;
        }
        #endregion

        #region ChangeLanguageCommand
        public ICommand ChangeLanguageCommand { get; }
        private void OnChangeLanguageCommandExecuted(object p)
        {
            
            switch (_CurrentLanguage)
            {
                case "ru-RU":
                    App.Language = new CultureInfo("en-US");
                    break;
                case "en-US":
                    App.Language = new CultureInfo("ru-RU");
                    break;
            }
        }
        private bool CanChangeLanguageCommandExecuted(object p) => true;
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
            ChangeLanguageCommand = new RelayCommand(OnChangeLanguageCommandExecuted, CanChangeLanguageCommandExecuted);
            ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted, CanChangeThemeCommandExecuted);
            #endregion

            #region Styles
            _Styles = new List<string> { "light", "dark" };
            _CurrentStyle = "light";
            #endregion

            #region Languages
            App.LanguageChanged += LanguageChanged;
            _CurrentLanguage = App.Language.Name;
            #endregion
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            _CurrentLanguage = App.Language.Name;
        }

    }
}
