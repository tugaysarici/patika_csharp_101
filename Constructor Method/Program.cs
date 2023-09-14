using System;

namespace Constructor_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            /* SÖZ DİZİMİ
            class SinifAdi
            {
                [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
                [Erişim Belirleyici] [Geri Dönüş Tipi] MethodAdi([Parametre Listesi])
                {
                    Metot Komutları
                }
            }
            */

            /*ERİŞİM BELİRLEYİCİLER
            Public
            Private
            Internal
            Protected
            */
            Console.WriteLine("Employee 1");
            Employee emp1 = new Employee();
            emp1.name = "Tugay";
            emp1.surname = "SARICI";
            emp1.no = 123454321;
            emp1.department = "DevOps";
            emp1.employeeInfo();

            Console.WriteLine("\nEmployee 2");
            Employee emp2 = new Employee("Mustafa", "KEMAL", 191919230, "R&D");
            emp2.employeeInfo();

            Console.WriteLine("\nEmployee 3");
            Employee emp3 = new Employee("Fernando", "MUSLERA");
            emp3.employeeInfo();
        }
    }
    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public Employee(string name, string surname, int no, string department)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.department = department;
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Employee(){}

        public void employeeInfo()
        {
            Console.WriteLine("Employee's name:{0}", name);
            Console.WriteLine("Employee's surname:{0}", surname);
            Console.WriteLine("Employee's no:{0}", no);
            Console.WriteLine("Employee's department:{0}", department);
        }
    }
}
