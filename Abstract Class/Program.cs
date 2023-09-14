using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------INTERFACE------");

            Focus focus = new Focus();
            Console.WriteLine(focus.whichBrand().ToString());
            Console.WriteLine(focus.whatColor().ToString());
            Console.WriteLine(focus.howManyWheels());

            Console.WriteLine("---------------------");

            Civic civic = new Civic();
            Console.WriteLine(civic.whichBrand().ToString());
            Console.WriteLine(civic.whatColor().ToString());
            Console.WriteLine(civic.howManyWheels());

            Console.WriteLine("------ABSTRACT------");

            NewFocus focus2 = new NewFocus();
            Console.WriteLine(focus2.whichBrand().ToString());
            Console.WriteLine(focus2.whatColor().ToString());
            Console.WriteLine(focus2.howManyWheels());

            Console.WriteLine("---------------------");

            NewCivic civic2 = new NewCivic();
            Console.WriteLine(civic2.whichBrand().ToString());
            Console.WriteLine(civic2.whatColor().ToString());
            Console.WriteLine(civic2.howManyWheels());

        }
    }
}
