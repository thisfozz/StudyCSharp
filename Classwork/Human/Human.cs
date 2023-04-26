using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class Human
    {
        private int idHuman;
        protected string name;
        protected string lastName;

        public Human(int id)
        {
            this.idHuman = id;
        }

        virtual public void Show()
        {
            Console.WriteLine($"\nID: {idHuman}\nИмя: {name}\nФамилия: {lastName}");
        }
    }
    internal class EmployeeOther : Human
    {
        protected decimal salary;
        public EmployeeOther(int id, string name, string lastName, decimal salary) : base(id)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;

        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Зарплата сотрудника: {salary}");
        }
    }
    internal class Programmer : EmployeeOther
    {
        private string rank;
        public Programmer(int id, string name, string lastName, decimal salary, string rank) : base(id, name, lastName, salary)
        {
            this.name = name;
            this.lastName = lastName;
            this.rank = rank;
            this.salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Зарплата программиста: {salary}");
            Console.WriteLine($"Ранг: {rank}");
        }

        public void WorkProgrammer()
        {
            Console.WriteLine("Working Programmger...");
        }
    }
    internal class Manager : EmployeeOther
    {
        private string descResp;
        public Manager(int id, string name, string lastName, decimal salary, string descResp) : base(id, name, lastName, salary)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
            this.descResp = descResp;
        }
        public override void Show()
        {
            Console.WriteLine($"Зарплата менеджера: {salary}");
            Console.WriteLine($"Описание обязанностей: {descResp}");
        }
        public void WorkManager()
        {
            Console.WriteLine("Working Manager...");
        }
    }
}
