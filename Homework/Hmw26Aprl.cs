using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework
{
    internal class Hmw26Aprl
    {
        static string DecimalToBase(int decimalNumber, int baseNumber)
        {
            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseNumber;
                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    result = ((char)(remainder - 10 + 'A')).ToString() + result;
                }
                decimalNumber /= baseNumber;
            }
            return result;
        }

        static int BaseToDecimal(string baseNumber, int baseValue)
        {
            int decimalNumber = 0;
            int power = 0;
            for (int i = baseNumber.Length - 1; i >= 0; i--)
            {
                int digit;
                if (baseNumber[i] >= '0' && baseNumber[i] <= '9')
                {
                    digit = baseNumber[i] - '0';
                }
                else if (baseNumber[i] >= 'A' && baseNumber[i] <= 'Z')
                {
                    digit = baseNumber[i] - 'A' + 10;
                }
                else
                {
                    throw new ArgumentException("Invalid input");
                }
                decimalNumber += digit * (int)Math.Pow(baseValue, power);
                power++;
            }
            return decimalNumber;
        }

        static void WordToInt(string word)
        {
            switch (word)
            {
                case "ноль":
                    Console.WriteLine(0);
                    break;
                case "один":
                    Console.WriteLine(1);
                    break;
                case "два":
                    Console.WriteLine(2);
                    break;
                case "три":
                    Console.WriteLine(3);
                    break;
                case "четыре":
                    Console.WriteLine(4);
                    break;
                case "пять":
                    Console.WriteLine(5);
                    break;
                case "шесть":
                    Console.WriteLine(6);
                    break;
                case "семь":
                    Console.WriteLine(7);
                    break;
                case "восемь":
                    Console.WriteLine(8);
                    break;
                case "девять":
                    Console.WriteLine(9);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
            Console.ReadLine();
        }
    }
    class Passport
    {
        private string number;
        private string name;
        private string surname;
        private DateTime issueDate;

        public Passport(string number, string name, string surname, DateTime issueDate)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("Номер паспорта не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Фамилия не может быть пустым");
            }
            if (issueDate > DateTime.Now)
            {
                throw new ArgumentException("Дата выдачи не может быть позже текущей даты");
            }

            this.number = number;
            this.name = name;
            this.surname = surname;
            this.issueDate = issueDate;
        }

        public void ChengeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Поле Имя не может быть пустым");
            }
            this.name = name;
        }

        public void ChengeSurame(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Поле Фамилия не может быть пустым");
            }
            this.surname = surname;
        }

        public string Number { get { return number; } }
        public string Name { get { return name; } }
        public string Surame { get { return surname; } }

        public DateTime IssueDate { get { return issueDate; } }
    }
}