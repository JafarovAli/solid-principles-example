using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP
{
   public class Database
   {
       public void Connect()
       {
           Console.WriteLine("The database was connect");
       }
       public void Disconnect()
       {
           Console.WriteLine("The database was disconnect");
       }

       public void GetPersons()
       {
           Console.WriteLine(" List of Person...");
       }
   }
}
