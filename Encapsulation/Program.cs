using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Name = "Tugay";
            st1.Surname = "SARICI";
            st1.StudentNumber = 345;
            st1.Grade = 5;
            st1.StudentInfoGet();

            st1.GradeUp();
            st1.StudentInfoGet();

            Student st2 = new Student("Mauro", "ICARDI", 444, 1);
            st2.StudentInfoGet();

            st2.GradeDown();
            st2.GradeDown();
            st2.StudentInfoGet();
        }
    }

    class Student
    {
        private string name; // buradayken ctrl + . bas ve alanı encapsulate et. name için elle yazıyorum diğerleri için otomatik oluşturuyorum.
        private string surname;
        private int studentNumber;
        private int grade;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname { get => surname; set => surname = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int Grade
        {
            get => grade;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Grade must be at leaset 1.");
                    grade = 1;
                }
                else
                    grade = value;
            }
        }

        public Student(string name, string surname, int studentNumber, int grade = 0)
        {
            this.name = name;
            this.surname = surname;
            this.studentNumber = studentNumber;
            this.grade = grade;
        }

        public Student() {}

        public void StudentInfoGet()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Student Name     :{0}", this.name);
            Console.WriteLine("Student Surname  :{0}", this.surname);
            Console.WriteLine("Student Number   :{0}", this.studentNumber);
            Console.WriteLine("Student Grade    :{0}", this.grade);
        }

        public void GradeUp()
        {
            this.Grade++;
        }
        public void GradeDown()
        {
            this.Grade--;
        }

    }
}