using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_OCP
{
   public class PulGonderme
   {
       public void Gonder(int mebleg)
       {
           //KapitalBank kapitalBank = new KapitalBank();
           //kapitalBank.HesabNomresi = "...";
           //kapitalBank.PulGonder(mebleg);

           Unibank unibank = new Unibank();
           unibank._hesabNomersi = "...";
           unibank.Gonder(mebleg);
       }
   }

   public class KapitalBank
   {
       public string HesabNomresi { get; set; }
       public void PulGonder(int mebleg)
       {
           //...
       }
   }
   public class Unibank
   {
       public string _hesabNomersi;
       public void GonderilecekHesabNomersi(string hesabNomresi)
       {
           //...
       }
       public void Gonder(int mebleg)
       {
           //...
       }
   }

}
