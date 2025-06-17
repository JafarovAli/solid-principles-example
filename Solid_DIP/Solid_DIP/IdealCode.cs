using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP
{
    public class MessageServise
    {
        public void SendMessage(IMessageServer messageServer,string to,string message)
        {
            messageServer.Send(to,message);
        }
    }

    public interface IMessageServer
    {
        void Send(string to,string message);
    }
    public class Whatsapp : IMessageServer
    {
        public void Send(string to,string message)
        {
            // ...send message...
        }
    }
    public class Telegram : IMessageServer
    {
        public void Send(string to, string message)
        {
            // ...send message...
        }
    }
    public class Signal : IMessageServer
    {
        public void Send(string to, string message)
        {
                // ...send message...
        }
    }
}
