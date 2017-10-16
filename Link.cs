using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOSPF
{
    class Link
    {
        public int BandWitdh { get; set; }
        public int Length { get; set; }

        private Router First;
        private Router End;
        
        public void Establish(ref Router A ,ref Router B)
        {

        }
    }
}
