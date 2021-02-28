using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VDemyanov.BankApp.Domain.Attributes;

namespace VDemyanov.BankApp.Domain.Persons
{
    public class Owner : IOwner
    {
        [Required(ErrorMessage = "Имя не установлено")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Имя не должно содержать цифр")]
        public string Name { get; protected set; }
        [Required(ErrorMessage = "Фамилия не установлена")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Фамилия не должна содержать цифр")]
        public string LastName { get; protected set; }
        [Required(ErrorMessage = "Отчество не установлено")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"([А-Я][а-я]+)|([A-Z][a-z]+)", ErrorMessage = "Отчество не должно содержать цифр")]
        public string MiddleName { get; protected set; }
        [Required(ErrorMessage = "Дата рождения не установлена")]
        public DateTime Birthday { get; protected set; }
        [Required]
        [PassportDataAttribute]
        public string PassportData { get; protected set; }

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
