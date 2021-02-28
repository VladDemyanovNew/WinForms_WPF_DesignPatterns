using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDemyanov.BankApp.BankAppWinForms.Settings
{
    public class InterfaceSettings
    {
        private static InterfaceSettings instance;

        public System.Drawing.Color MenuBackColor { get; private set; }
        public System.Drawing.Color ButtonBackColor { get; private set; }
        public System.Drawing.Color ButtonPanelBackColor { get; private set; }
        public System.Drawing.Color FooterBackColor { get; private set; }
        public System.Drawing.Color HeaderBackColor { get; private set; }
        public System.Drawing.Color ForeColor { get; private set; }

        protected InterfaceSettings(
            System.Drawing.Color MenuBackColor,
            System.Drawing.Color ButtonBackColor,
            System.Drawing.Color ButtonPanelBackColor,
            System.Drawing.Color FooterBackColor,
            System.Drawing.Color HeaderBackColor,
            System.Drawing.Color ForeColor
            )
        {
            this.MenuBackColor = MenuBackColor;
            this.ButtonBackColor = ButtonBackColor;
            this.ButtonPanelBackColor = ButtonPanelBackColor;
            this.FooterBackColor = FooterBackColor;
            this.HeaderBackColor = HeaderBackColor;
            this.ForeColor = ForeColor;
        }

        public static InterfaceSettings getInstance(
            System.Drawing.Color MenuBackColor,
            System.Drawing.Color ButtonBackColor,
            System.Drawing.Color ButtonPanelBackColor,
            System.Drawing.Color FooterBackColor,
            System.Drawing.Color HeaderBackColor,
            System.Drawing.Color ForeColor
            )
        {
            if (instance == null)
                instance = new InterfaceSettings(
                    MenuBackColor,
                    ButtonBackColor,
                    ButtonPanelBackColor,
                    FooterBackColor,
                    HeaderBackColor,
                    ForeColor
                    );
            return instance;
        }
    }
}
