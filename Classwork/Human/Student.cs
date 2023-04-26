using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class Student
    {
        public Student() { }
        public Student(int StudentID) : this(StudentID, "", 0) { }
        public Student(int StudentID, string Name) : this(StudentID, Name, 0) { }
        public Student(int StudentID, string Name, int Age)
        {
            this.StudentID = StudentID;
            this.Name = Name;
            this.Age = Age;
            GroupName = "TestGroupName";
            marks = new int[5] { 5, 4, 3, 2, 4 };
        }
        // Поля - private, protected, public, internal
        private int StudentID;
        private int Age;
        private int Course;
        public string Name;
        private int[] marks;

        // Свойства
        public int AgeOther
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Невалидные данные");
                    return;
                }
                Age = value;
            }
        }
        public string GroupName { get; private set; }
        public void SetAge(int Age)
        {
            if (Age < 0)
            {
                Console.WriteLine("Невалидные данные");
                return;
            }
            this.Age = Age;
        }
        public int GetAge()
        {
            return Age;
        }
        // Методы

        public void ChangeCourse(int courseNumber)
        {
            Course = courseNumber;
        }

        public bool TryGetMark(int index, out int mark)
        {
            if (index < 0 || index >= marks.Length)
            {
                mark = 0;
                return false;
            }
            mark = marks[index];
            return true;
        }

        public void SumMarks(ref int result)
        {
            result = marks.Sum();
        }

        static int Multiply(params int[] values)
        {
            int result = 0;
            foreach (var n in values)
            {
                result += n;
            }
            return result;
        }

        public void MultiplyExample()
        {
            int[] numbers = new int[] { 4, 3, 4, 5, 1, 2, 3, 4 };
            Console.WriteLine($"Произведение массива через массив: {Multiply(numbers)}\n");
            Console.WriteLine($"Произведение массива через params: {Multiply(4, 3, 4, 5, 1, 2, 3, 4)}");
        }

        public override string ToString()
        {
            return $"ID {StudentID}\nName: {Name} ";
        }
    }
}
