using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP
{
    public abstract class Animate
    {
        public abstract void Eat();
        public abstract void Speak();
    }

    public class Person : Animate
    {
        public override void Eat()
            => Console.WriteLine("Person ate");

        public override void Speak()
            => Console.WriteLine("Person spoke");
    }

    public class Animal : Animate
    {
        public override void Eat()
            => Console.WriteLine("Animal ate");

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
