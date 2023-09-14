using System;

namespace Inheritance
{
    public class Animals:Bios
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals can be adapted.");
        }

        public override void Reaction()
        {
            base.Reaction();
            Console.WriteLine("Animals gives reaction to contact.");
        }
    }

    public class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Feed();
            base.Excrete();
            base.Breathe();
        }
        public void Crawl()
        {
            Console.WriteLine("Reptiles crawl.");
        }
    }

    public class Birds:Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Feed();
            base.Excrete();
            base.Breathe();
            base.Reaction();
        }
        public void Fly()
        {
            Console.WriteLine("Birds fly.");
        }
    }
}
