using System;

namespace Inheritance
{
    // public'ten sonra sealed kullanırsan kalıtımı engellemiş olursun.
    public class Bios
    {
        protected void Feed()
        {
            Console.WriteLine("Bios feed.");
        }

        protected void Breathe()
        {
            Console.WriteLine("Bios breathe.");
        }

        protected void Excrete()
        {
            Console.WriteLine("Bios excrete.");
        }

        public virtual void Reaction()
        {
            Console.WriteLine("Bios give reaction to stimuli.");
        }
    }
}
