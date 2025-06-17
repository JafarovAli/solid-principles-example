using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_OCP
{
    public class PulGonderme
    {
        public void Gonder(IBank bank,int mebleg,string hesabNomresi)
        {
            bank.PulTransferi(mebleg, hesabNomresi);
        }
    }

    public interface IBank
    {
        bool PulTransferi(int mebleg,string hesabNomeri);
    }


    public class KapitalBank:IBank
    {
        public string HesabNomresi { get; set; }
        public void PulGonder(int mebleg)
        {
            //...
        }

        public bool PulTransferi(int mebleg, string hesabNomeri)
        {
            return true;
        }
    }


    public class Unibank:IBank
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

        public bool PulTransferi(int mebleg, string hesabNomeri)
        {
            return true;
        }
    }
}
