using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.C_HW_modul_06
{
    internal abstract class Worker
    {
        public abstract void Print();
    }

    internal class President : Worker
    {
        public override void Print()
        {
            Console.Write("Я Президент!");
        }
    }
    internal class Security : Worker
    {
        public override void Print()
        {
            Console.Write("Я Охранник!");
        }
    }
    internal class Manager : Worker
    {
        public override void Print()
        {
            Console.Write("Я Менеджер!");
        }
    }
    internal class Engineer : Worker
    {
        public override void Print()
        {
            Console.Write("Я Инженер!");
        }
    }
}
