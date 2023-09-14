using System;

namespace Static_Classes_and_Static_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of employees: {0}", Employee.NumberOfEmployees);
            
            Employee emp1 = new Employee("Tugay", "SARICI", "DevOps");
            Console.WriteLine("The number of employees: {0}", Employee.NumberOfEmployees);
            Employee emp2 = new Employee("Fernando", "MUSLERA", "Security");
            Employee emp3 = new Employee("Bulent", "KORKMAZ", "Designer");
            Console.WriteLine("The number of employees: {0}", Employee.NumberOfEmployees);

            Console.WriteLine("The result of the addition operation: {0}", Operations.Addition(200,50));
            Console.WriteLine("The result of the subtraction operation: {0}", Operations.Subtraction(200,50)); 
        }
    }

    class Employee
    {
        private static int numberOfEmployees;
        private string name;
        private string surname;
        private string department;

        public static int NumberOfEmployees { get => numberOfEmployees; }

        static Employee()
        {
            numberOfEmployees = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            numberOfEmployees++;
        }
    }

    static class Operations
    {
        public static long Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
