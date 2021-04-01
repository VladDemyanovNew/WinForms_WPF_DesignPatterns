using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDemyanov.Shop.ShopWPF.Views.ViewInfrastructure
{
    interface IMainWindowsCodeBehind
    {
        /// <summary>
        /// Загрузка нужной View
        /// </summary>
        /// <param name="view">экземпляр UserControl</param>
        void LoadView(ViewType typeView);
    }
}
