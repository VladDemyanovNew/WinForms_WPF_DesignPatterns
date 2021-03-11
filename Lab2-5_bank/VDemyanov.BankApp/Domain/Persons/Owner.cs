using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VDemyanov.BankApp.Domain.Attributes;

namespace VDemyanov.BankApp.Domain.Persons
{
    [Serializable]
    public class Owner : IOwner
    {
        [Required(ErrorMessage = "Имя не установлено")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Имя не должно содержать цифр")]
        public string Name { get; }
        [Required(ErrorMessage = "Фамилия не установлена")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Фамилия не должна содержать цифр")]
        public string LastName { get; }
        [Required(ErrorMessage = "Отчество не установлено")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Отчество не должно содержать цифр")]
        public string MiddleName { get; }
        [Required(ErrorMessage = "Дата рождения не установлена")]
        public DateTime Birthday { get; }
        [Required]
        [PassportDataAttribute]
        public string PassportData { get; }

        private Owner() { }

        public Owner(string name, string lastName, string middleName, DateTime birthday, string passportData)
        {
            this.Name = name;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Birthday = birthday;
            this.PassportData = passportData;
        }

        public override string ToString()
        {
            return this.Name + " " + this.LastName + " " + this.MiddleName + " " + this.Birthday + " " + this.PassportData;
        }

        public IOwner Clone()
        {
            return new Owner(this.Name, this.LastName, this.MiddleName, this.Birthday, this.PassportData);
        }

        public string GetInfo()
        {
            return this.Name + " " + this.LastName + " " + this.MiddleName + " " + this.Birthday + " " + this.PassportData;
        }
    }
}
