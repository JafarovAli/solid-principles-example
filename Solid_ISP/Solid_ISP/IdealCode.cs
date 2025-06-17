using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    public interface IEtCeken
    {
        void EtCekir();
    }
    public interface IPaltarYuyan
    {
        void PaltarYuyur();
    }
    public interface IQabYuyur
    {
        void QabYuyur();
    }

    public class Et_Ceken_Masin : IEtCeken
    {
        public void EtCekir()
        {
            Console.WriteLine("Et cekir");
        }
    }

    public class Paltar_Yuyan_Masin : IPaltarYuyan
    {

        public void PaltarYuyur()
        {
            Console.WriteLine("Paltar Yuyur");
        }
    }

    public class Qab_Yuyan_Masin : IQabYuyur
    {
        public void QabYuyur()
        {
            Console.WriteLine("Qab yuyur");
        }
    }
}
