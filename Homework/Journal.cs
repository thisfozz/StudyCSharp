using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudyCSharp.Homework
{
    internal class Journal
    {
        private string name;
        private DateTime year;
        private string description;
        private string phone;
        private string email;
        private UInt64 numberOfStaff;

        public Journal(string name, DateTime year, string description, string phone, string email, UInt64 numberOfStaff = 0)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }
            if (year > DateTime.Now)
            {
                throw new ArgumentException("Дата создания журнала не может быть позже текущей даты");
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Описание не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Номер телефона не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("E-mail не может быть пустым");
            }

            this.name = name;
            this.year = year;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.numberOfStaff = numberOfStaff;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Поле Имя не может быть пустым");
            }
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYear(DateTime year)
        {
            if (year > DateTime.Now)
            {
                throw new ArgumentException("Дата создания журнала не может быть позже текущей даты");
            }
            this.year = year;
        }

        public DateTime GetYear()
        {
            return year;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Описание не может быть пустым");
            }
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Номер телефона не может быть пустым");
            }
            this.phone = phone;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Поле E-mail не может быть пустым");
            }
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void InputData()
        {
            Console.WriteLine("Введите название журнала:");
            name = Console.ReadLine();
            Console.WriteLine("Введите год создания:");
            year = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание журнала:");
            description = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            phone = Console.ReadLine();
            Console.WriteLine("Введите e-mail:");
            email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Название журнала: {name}");
            Console.WriteLine($"Год создания: {year}");
            Console.WriteLine($"Описание журнала: {description}");
            Console.WriteLine($"Номер телефона: {phone}");
            Console.WriteLine($"E-mail: {email}");
        }



        // Увеличение количества сотрудников
        public static Journal operator +(Journal journal, UInt64 value = 0)
        {
            UInt64 result = journal.numberOfStaff + value;
            return new Journal(journal.name, journal.year,journal.description, journal.phone, journal.email, result);
        }

        // Уменьшение количества сотрудников
        public static Journal operator -(Journal journal, UInt64 value = 0)
        {
            UInt64 result = 0;
            if (journal.numberOfStaff - value > 0) {
                result = journal.numberOfStaff - value;
            }
            else
            {
                throw new ArgumentException("Число не может превышать количество сотрудников");
            }
            return new Journal(journal.name, journal.year, journal.description, journal.phone, journal.email, result);
        }

        // Проверка на неравенство количества сотрудников
        public static bool operator !=(Journal journalSourse, Journal journalOther)
        {
            return journalSourse.numberOfStaff != journalOther.numberOfStaff;
        }

        //Проверка на равенство количества сотрудников
        public static bool operator ==(Journal journalSourse, Journal journalOther)
        {
            return journalSourse.numberOfStaff == journalOther.numberOfStaff;
        }

        public static bool operator <(Journal journalSourse, Journal journalOther)
        {
            return journalSourse.numberOfStaff < journalOther.numberOfStaff;
        }
        public static bool operator >(Journal journalSourse, Journal journalOther) 
        {
            return journalSourse.numberOfStaff > journalOther.numberOfStaff;
        }
    }
}
