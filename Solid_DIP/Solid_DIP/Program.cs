using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Not Ideal Code

            //MessageServise messageServise = new MessageServise();
            //messageServise.SendMessage(new Whatsapp());

            //Ideal Code

            MessageServise messageServise = new MessageServise();
            messageServise.SendMessage(new Whatsapp(), "...", "...");
            messageServise.SendMessage(new Telegram (), "...", "...");
            messageServise.SendMessage(new Signal(), "...", "...");

        }
    }
}
