using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOSPF
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTopo Topo = new MyTopo();
            Topo.Number = 4;
            Topo.setList();
            Topo.newConection(0, 1);
            Topo.showInfo();
            Console.ReadKey();
        }
    }
}
