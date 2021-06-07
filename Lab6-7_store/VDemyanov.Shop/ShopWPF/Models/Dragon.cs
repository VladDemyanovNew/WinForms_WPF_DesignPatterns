using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VDemyanov.Shop.ShopWPF.Models
{
    public class Dragon : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty PowerProperty;
        public static readonly DependencyProperty HealthProperty;

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public int Power
        {
            get { return (int)GetValue(PowerProperty); }
            set { SetValue(PowerProperty, value); }
        }
        public int Health
        {
            get { return (int)GetValue(HealthProperty); }
            set { SetValue(HealthProperty, value); }
        }

        static Dragon()
        {
            NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Dragon));

            FrameworkPropertyMetadata metadataPower = new FrameworkPropertyMetadata();
            metadataPower.CoerceValueCallback = new CoerceValueCallback(CorrectPowerValue);
            PowerProperty = DependencyProperty.Register("Power", typeof(int), typeof(Dragon), metadataPower,
            new ValidateValueCallback(ValidatePositiveValue));

            FrameworkPropertyMetadata metadataHealth = new FrameworkPropertyMetadata();
            metadataHealth.CoerceValueCallback = new CoerceValueCallback(CorrectHealthValue);
            HealthProperty = DependencyProperty.Register("Health", typeof(int), typeof(Dragon), metadataHealth,
            new ValidateValueCallback(ValidatePositiveValue));
        }

        private static object CorrectHealthValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 6000)
                return 6000;
            return currentValue;
        }

        private static object CorrectPowerValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)
                return 1000;
            return currentValue;
        }

        private static bool ValidatePositiveValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0)
                return true;
            return false;
        }

       
    }
}
