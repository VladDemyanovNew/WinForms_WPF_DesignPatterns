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
using System.Windows.Shapes;

namespace VDemyanov.Shop.ShopWPF.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public static RoutedCommand CustomRoutedCommand = new RoutedCommand();

        public TestWindow()
        {
            InitializeComponent();

            CommandBinding customCommandBinding = new CommandBinding(CustomRoutedCommand, ExecutedCustomCommand, CanExecuteCustomCommand);

            // attach CommandBinding to root window
            this.CommandBindings.Add(customCommandBinding);
        }

        private void ExecutedCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Custom Command Executed");
        }

        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            Control target = e.Source as Control;

            if (target != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void Control_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n";
        }

        private void Control_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            textBlock2.Text = textBlock2.Text + "sender: " + sender.ToString() + "\n";
            textBlock2.Text = textBlock2.Text + "source: " + e.Source.ToString() + "\n";
        }

        private void Control_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            textBlock3.Text = textBlock3.Text + "sender: " + sender.ToString() + "\n";
            textBlock3.Text = textBlock3.Text + "source: " + e.Source.ToString() + "\n";
        }
    }
}
