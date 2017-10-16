using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOSPF
{
    class MyTopo
    {
        private int number;

        static public  List<Router> ListRouter = new List<Router>();
        public int Number
        {
            get {
                return  number;
            }
            set
            {
                number = value;
            }

        }

        public void setList()
        {
            for(int i = 0 ; i < number ; i++)
            {
                Router tmp = new Router();
                tmp.ID = i;
                ListRouter.Add(tmp);
            }
        }

        public void Hello()
        {
            foreach (Router rt in ListRouter)
            {
               
            }
        }

        public void newConection(int a, int b)
        {
            ListRouter[a].newConection(ListRouter[b]);
            ListRouter[b].newConection(ListRouter[a]);
        }
        public void  showInfo()
        {
            foreach (Router element in ListRouter)
            {
                element.showInfo();
            }
        }

    }
}
