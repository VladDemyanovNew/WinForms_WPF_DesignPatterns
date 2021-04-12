using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using VDemyanov.Shop.ShopWPF.ViewModels;
using VDemyanov.Shop.ShopWPF.Views.ViewInfrastructure;
using VDemyanov.Shop.ShopWPF.Views.Windows;

namespace VDemyanov.Shop.ShopWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.Loaded += MainWindow_Loaded;
        }

        private void App_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel vm = new MainWindowViewModel();
            //даем доступ к этому кодбихайнд
            vm.CodeBehind = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            //загрузка стартовой View
            LoadView(ViewType.PRODUCTS);
        }

        /// <summary>
        /// Загружает нужное представление
        /// </summary>
        /// <param name="typeView"></param>
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.PRODUCTS:
                    //загружаем вьюшку, ее вьюмодель
                    Products viewP = new Products();
                    ProductsViewModel vmP = new ProductsViewModel(this);
                    //связываем их м/собой
                    viewP.DataContext = vmP;
                    //отображаем
                    this.OutputView.Content = viewP;
                    break;
                case ViewType.ADMIN_TOOLS:
                    AdminTools viewAT = new AdminTools();
                    AdminToolsViewModel vmAT = new AdminToolsViewModel(this);
                    viewAT.DataContext = vmAT;
                    this.OutputView.Content = viewAT;
                    break;
            }
        }

    }
}
