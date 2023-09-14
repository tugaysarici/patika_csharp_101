using System;

namespace Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.whichBrand().ToString());
            Console.WriteLine(focus.whatColor().ToString());
            Console.WriteLine(focus.howManyWheels());

            Civic civic = new Civic();
            Console.WriteLine(civic.whichBrand().ToString());
            Console.WriteLine(civic.whatColor().ToString());
            Console.WriteLine(civic.howManyWheels());
        }
    }
}
