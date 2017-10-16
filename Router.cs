using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOSPF
{
    class Router
    {
        private int id;

        private List<Router> ListConnected = new List<Router>();
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public void showInfo()
        {
            Console.Write("ID : {0}  ", ID);
            Console.Write("List Connected : ");
            foreach(Router r in ListConnected)
            {
                Console.Write("Router {0}", r.ID);
            }
            Console.WriteLine("");
        }

        public void SendHello()
        {
            Packet Hello = new Packet();
            Hello.Type = (int)PacketType.Hello;

        }

      public void newConection(Router R)
        {
            ListConnected.Add(R);
        }



    }
}
