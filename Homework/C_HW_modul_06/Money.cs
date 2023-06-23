using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.C_HW_modul_06
{
    internal class Money
    {
        private int dollar;
        private int euro;
        private int dollarCents;
        private int euroCents;

        public Money(int dollar, int dollarCents)
        {
            this.dollar = dollar;
            this.dollarCents = dollarCents;
        }

        public int Dollar { get { return dollar; } set { dollar = value; } }
        public int Euro { get {  return euro; } set {  euro = value; } }
        public int DollarCents { get {  return dollarCents; } set { dollarCents = value; } }
        public int EuroCents { get { return euroCents; } set { euroCents = value; } }

        public void PrintDollar()
        {
            Console.WriteLine($"{Dollar}.{DollarCents}");
        }
        public void PrintEuro()
        {
            Console.WriteLine($"{Euro}.{EuroCents}");
        }
    }

    internal class Product
    {
        private string nameProduct;
        private Money price;

        public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }
        public Money Price { get {  return price; } set { price = value;} }

        public void ReducePriceDollar(int dollars, int cents)
        {
            if(price.Dollar - dollars >= 0)
            {
                price.Dollar -= dollars;
            }
            else
            {
                Console.Write($"Введенное число долларов {dollars} превышает цену товара {price.Dollar}");
            }
            if (price.DollarCents - cents >= 0)
            {
                price.DollarCents -= cents;
                Console.Write($"Введенное число долларов {cents} превышает цену товара {price.DollarCents}");
            }
        }
        public void ReducePriceEuro(int Euro, int EuroCents)
        {
            if (price.Euro - Euro >= 0)
            {
                price.Euro -= Euro;
            }
            else
            {
                Console.Write($"Введенное число долларов {Euro} превышает цену товара {price.Euro}");
            }
            if (price.EuroCents - EuroCents >= 0)
            {
                price.EuroCents -= EuroCents;
                Console.Write($"Введенное число долларов {EuroCents} превышает цену товара {price.EuroCents}");
            }
        }
    }
}
