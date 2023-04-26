using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class Employee
    {
        public Employee(string NameEmpl, string SurnameEmpl, string PatronymicEmpl, UInt64 PhoneNumberEmpl)
        {
            this.NameEmpl = NameEmpl;
            this.SurnameEmpl = SurnameEmpl;
            this.PatronymicEmpl = PatronymicEmpl;
            this.PhoneNumberEmpl = PhoneNumberEmpl;
        }

        public void setNameEmpl(string NameEmpl)
        {
            if (this.NameEmpl == NameEmpl)
            {
                Console.Write("Имя совпадает с текущим.");
                return;
            }
            else
            {
                Console.Write($"Имя успешно изменено с {this.NameEmpl} на {NameEmpl}");
                this.NameEmpl = NameEmpl;
            }
        }
        public void setSurnameEmpl(string SurnameEmpl)
        {
            if (this.SurnameEmpl == SurnameEmpl)
            {
                Console.Write("Фамилия совпадает с текущей.");
                return;
            }
            else
            {
                Console.Write($"Фамилия успешно изменена с {this.SurnameEmpl} на {SurnameEmpl}");
                this.SurnameEmpl = SurnameEmpl;
            }
        }
        public void setPatronymicEmpl(string PatronymicEmpl)
        {
            if (this.PatronymicEmpl == PatronymicEmpl)
            {
                Console.Write("Отчество совпадает с текущим.");
                return;
            }
            else
            {
                Console.Write($"Отчество успешно изменено с {this.PatronymicEmpl} на {PatronymicEmpl}");
                this.PatronymicEmpl = PatronymicEmpl;
            }
        }
        public void setEmailEmpl(string EmailEmpl)
        {
            if (this.EmailEmpl == EmailEmpl)
            {
                Console.Write("Электронная почта совпадает с текущей.");
                return;
            }
            else
            {
                Console.Write($"Электронный адрес успешно изменен с {this.EmailEmpl} на {EmailEmpl}");
                this.EmailEmpl = EmailEmpl;
            }
        }
        public void setPhoneNumberEmpl(UInt64 PhoneNumberEmpl)
        {
            if (this.PhoneNumberEmpl == PhoneNumberEmpl)
            {
                Console.Write("Номер телефона совпадает с текущим.");
                return;
            }
            else
            {
                Console.Write($"Электронный адрес успешно изменен с {this.PhoneNumberEmpl} на {PhoneNumberEmpl}");
                this.PhoneNumberEmpl = PhoneNumberEmpl;
            }
        }
        public void setDateBirthsdayEmpl(DateTime DateBirthsdayEmpl)
        {
            if (this.DateBirthsdayEmpl == DateBirthsdayEmpl)
            {
                Console.Write("Дата рождения совпадает с текущей.");
                return;
            }
            else
            {
                Console.Write($"Дата рождения успешно изменена с {this.DateBirthsdayEmpl} на {DateBirthsdayEmpl}");
                this.DateBirthsdayEmpl = DateBirthsdayEmpl;
            }
        }
        public override string ToString()
        {
            return
                $"Имя сотрудника: {NameEmpl}" +
                $"\nФамилия сотрудника: {SurnameEmpl}" +
                $"\nОтчество сотрудника:{PatronymicEmpl}" +
                $"\nЭлектронный адрес сотрудника: {EmailEmpl}" +
                $"\nНомер телефона сотрудника: {PhoneNumberEmpl}" +
                $"\nДата рождения сотрудника: {DateBirthsdayEmpl.ToString("dd.MM.yyyy")}" +
                $"\nОписание служебных обязаенностей: {DescServiceEmpl}" +
                $"\nДолжность сотрудника: {JobTitleEmpl} ";
        }


        private string NameEmpl;
        private string SurnameEmpl;
        private string PatronymicEmpl;
        private string EmailEmpl;
        private UInt64 PhoneNumberEmpl;
        private DateTime DateBirthsdayEmpl;
        public string DescServiceEmpl { get; set; }
        public string JobTitleEmpl { get; set; }
    }
}
