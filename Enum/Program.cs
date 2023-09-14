using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            int temprature = 27;
            if(temprature <= (int)weather.normal)
            {
                Console.WriteLine("The weather is below normal.");
            }
            else if(temprature >= (int)weather.extreme)
            {
                Console.WriteLine("The weather is so hot to go on a walk.");
            }
            else if(temprature >= (int)weather.normal && temprature <= (int)weather.hot)
            {
                Console.WriteLine("Let's go out!");
            }
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 23,
        Saturday,
        Sunday
    }

    enum weather
    {
        cold = 5,
        normal = 23,
        hot = 28,
        extreme = 34
    }
}
