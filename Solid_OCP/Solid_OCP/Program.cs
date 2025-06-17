using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PulGonderme pulGonderme = new PulGonderme();
            pulGonderme.Gonder(new KapitalBank(), 100, "sdbaid");
        }
    }
}
