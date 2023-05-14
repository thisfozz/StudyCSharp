using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.C_HW_modul_06
{
    internal abstract class Device
    {
        protected string deviceName;
    }
    internal class Teapot : Device
    {
        public Teapot()
        {
            deviceName = "Teapot";
        }

        public void Desc()
        {
            Console.Write($"Description {deviceName}");
        }

        public void Show()
        {
            Console.Write($"{deviceName}");
        }

        public void Sound()
        {
            Console.Write($"Sound {deviceName}");
        }

    }

    internal class Microwave : Device
    {

        public Microwave()
        {
            deviceName = "Microwave";
        }

        public void Desc()
        {
            Console.Write($"Description {deviceName}");
        }

        public void Show()
        {
            Console.Write($"{deviceName}");
        }

        public void Sound()
        {
            Console.Write($"Sound {deviceName}");
        }
    }
}
