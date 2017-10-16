using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyOSPF
{
    enum PacketType
    {
        Hello, LSA
    }
    class Packet
    {
        private int  type;
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        
    }
}
