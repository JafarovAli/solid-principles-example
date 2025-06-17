using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP
{
   public class MessageServise
   {
       public void SendMessage(Whatsapp whatsapp)
       {
           whatsapp.Send("...");
       }
   }

   public class Whatsapp
   {
       public void Send(string message)
       {
           // ...send message...
       }
   }
   public class Telegram
   {
       public void SendTelegram(string message)
       {
           // ...send message...
       }
   }
   public class Signal
   {
       public void SendSignal(string message)
       {
           // ...send message...
       }
   }

}
