using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                          Canlılar
            //                              |
            //          Bitkiler                            Hayvanlar
            //              |                                   |
            //  Tohumlu         Tohumsuz        Surungenler            Kuslar
            SeedPlants seedPlant = new SeedPlants();
            seedPlant.PropagateBySeed();

            Console.WriteLine("--------------");

            Birds crow = new Birds();
            crow.Fly();
        }
    }
}
