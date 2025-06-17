using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    public interface ITechnology
    {
        void EtCekir();
        void PaltarYuyur();
        void QabYuyur();
    }
    public class EtCekenMasin : ITechnology
    {
        public void EtCekir()
        {
            Console.WriteLine("Et cekir");
        }

        public void PaltarYuyur()
        {
            throw new NotImplementedException();
        }

        public void QabYuyur()
        {
            throw new NotImplementedException();
        }
    }

    public class PaltarYuyanMasin : ITechnology
    {
        public void EtCekir()
        {
            throw new NotImplementedException();
        }

        public void PaltarYuyur()
        {
            Console.WriteLine("Paltar Yuyur");
        }

        public void QabYuyur()
        {
            throw new NotImplementedException();
        }
    }

    public class QabYuyanMasin : ITechnology
    {
        public void EtCekir()
        {
            throw new NotImplementedException();
        }

        public void PaltarYuyur()
        {
            throw new NotImplementedException();
        }

        public void QabYuyur()
        {
            Console.WriteLine("Qab yuyur");
        }
    }
}
