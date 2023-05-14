using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal class C_HW_modul_01
    {
        public void Task1()
        {
            Console.Write("Введите число в диапазоне 1-100: ");
            int value = int.Parse(Console.ReadLine());

            if (value >= 1 && value <= 100)
            {
                if ((value % 3 == 0) && (value % 5 == 0))
                    Console.Write("Fizz Buzz");
                else if (value % 3 == 0)
                    Console.Write("Fizz");
                else if (value % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write($"{value}");
            }
            else
                Console.Write($"Ошибка: введенное число {value} находится не в диапазоне 1-100");

        }
        public void Task2()
        {
            Console.Write("Введите число: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Введите процент: ");
            double percent = double.Parse(Console.ReadLine());

            double result = value * (percent / 100);
            Console.WriteLine(percent + "% от " + value + " = " + result);
        }
        public void Task3()
        {
            Console.Write("Введите первую цифру: ");
            int valueOne = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую цифру: ");
            int valueTwo = int.Parse(Console.ReadLine());

            Console.Write("Введите третью цифру: ");
            int valueThree = int.Parse(Console.ReadLine());

            Console.Write("Введите четвертую цифру: ");
            int ValueFour = int.Parse(Console.ReadLine());

            int result = valueOne * 1000 + valueTwo * 100 + valueThree * 10 + ValueFour;
            Console.WriteLine("Результат: " + result);
        }
        public void Task4()
        {
            Console.Write("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (!(number >= 1000000 && number <= 999999))
            {
                Console.Write("Введенное число не шестизначное");
                return;
            }
            Console.Write("Введите номера разрядов для обмена: ");
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());

            int[] digits = new int[6];
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            (digits[index2 - 1], digits[index1 - 1]) = (digits[index1 - 1], digits[index2 - 1]);

            int result = 0;
            for (int i = 0; i < 6; i++)
                result += digits[i] * (int)Math.Pow(10, 5 - i);

            Console.WriteLine($"Результат: {result}");
        }
        public void Task5()
        {
            Console.WriteLine("Введите дату (например, 15.04.2023):");
            string inputDate = Console.ReadLine();

            DateTime date;
            if (!DateTime.TryParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Ошибка: неверный формат даты.");
                return;
            }

            string season = "";
            if (date.Month >= 3 && date.Month <= 5)
                season = "весна";
            else if (date.Month >= 6 && date.Month <= 8)
                season = "лето";
            else if (date.Month >= 9 && date.Month <= 11)
                season = "осень";
            else
                season = "зима";

            string dayOfWeek = date.ToString("dddd", CultureInfo.GetCultureInfo("ru-RU"));

            Console.WriteLine($"Дата: {date.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Сезон: {season}");
            Console.WriteLine($"День недели: {dayOfWeek}");
        }
        public void Task6()
        {
            Console.WriteLine("Введите температуру:");
            double temperature;
            if (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Ошибка: неверный формат температуры.");
                return;
            }

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Перевести в Цельсий");
            Console.WriteLine("2. Перевести в Фаренгейт");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Ошибка: неверный выбор.");
                return;
            }

            double convertedTemperature;
            if (choice == 1)
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature} градусов Фаренгейта = {convertedTemperature} градусов Цельсия.");
            }
            else
            {
                convertedTemperature = temperature * 9 / 5 + 32;
                Console.WriteLine($"{temperature} градусов Цельсия = {convertedTemperature} градусов Фаренгейта.");
            }
        }
        public void Task7()
        {
            Console.Write("Введите начало диапазона: ");
            int beginRange = int.Parse(Console.ReadLine());

            Console.Write("Введите конец диапазона: ");
            int endRange = int.Parse(Console.ReadLine());

            if (beginRange > endRange)
                (endRange, beginRange) = (beginRange, endRange);
            else
                Console.Write($"Начало диапазона {beginRange} не может быть меньше конца диапазона {endRange}");

            Console.Write($"Четные числа в диапазоне от {beginRange} до {endRange}: ");
            for (int i = beginRange; i <= endRange; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}