using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP
{
    public abstract class Animates
    {
        public abstract void Eat();
    }

    public interface IAnimateSpeak
    {
        void Speak();
    }
    public class Persons : Animates,IAnimateSpeak
    {
        public override void Eat()
            => Console.WriteLine("Person ate");

        public void Speak()
            => Console.WriteLine("Person spoke");
    }

    public class Animals : Animates
    {
        public override void Eat()
            => Console.WriteLine("Animal ate");
    }
}
