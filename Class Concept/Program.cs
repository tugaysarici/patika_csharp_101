using System;

namespace Class_Concept
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
            Employee emp1 = new Employee();
            emp1.name = "Tugay";
            emp1.surname = "SARICI";
            emp1.no = 123454321;
            emp1.department = "DevOps";
            emp1.employeeInfo();

            Console.WriteLine("----------------------------");

            Employee emp2 = new Employee();
            emp2.name = "Mustafa";
            emp2.surname = "KEMAL";
            emp2.no = 019191923;
            emp2.department = "R&D";
            emp2.employeeInfo();
        }
    }
    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;
        public void employeeInfo()
        {
            Console.WriteLine("Employee's name:{0}", name);
            Console.WriteLine("Employee's surname:{0}", surname);
            Console.WriteLine("Employee's no:{0}", no);
            Console.WriteLine("Employee's department:{0}", department);
        }
    }
}
