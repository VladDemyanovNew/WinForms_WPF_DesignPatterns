using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public static class DataSettings
    {
        public static string UserNameField { get; } = "имя";
        public static string UserLastNameField { get; } = "фамилия";
        public static string UserMiddleNameField { get; } = "отчество";
        public static string PassportDataField { get; } = "паспортные данные";
    }
}
