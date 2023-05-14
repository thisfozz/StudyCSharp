using StudyCSharp.Homework;
using StudyCSharp.Homework.C_HW_modul_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money price = new Money(10, 50);
            Product product = new Product("Молоко", price);
            product.Price.Print(); // 10.50
            product.ReducePrice(2, 30);
            product.Price.Print(); // 8.20
        }
    }
}
