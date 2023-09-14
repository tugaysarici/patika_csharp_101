using System;

namespace Inheritance
{
    public class Plants:Bios
    {
        protected void Photosynthesize()
        {
            Console.WriteLine("Plants photosynthesize.");
        }

        public override void Reaction()
        {
            //base.Reaction();
            Console.WriteLine("Plants gives reaction to the sun.");
        }
    }

    public class SeedPlants:Plants
    {
        public SeedPlants()
        {
            base.Photosynthesize();
            base.Feed();
            base.Excrete();
            base.Breathe();
            base.Reaction();
        }
        public void PropagateBySeed()
        {
            Console.WriteLine("Seed plants propagate by seed.");
        }
    }

    public class SeedlessPlants:Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesize();
            base.Feed();
            base.Excrete();
            base.Breathe();
        }
        public void PropagateBySpore()
        {
            Console.WriteLine("Seedless plants propagate by spore.");
        }
    }
}
