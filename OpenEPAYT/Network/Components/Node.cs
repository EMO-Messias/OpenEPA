using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public abstract class Node
    {

       
        public string ID { get; set; }
        public double Elevation { get; set; }
        public string Pattern { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; } 
        public abstract string ExportItemSection();
    }
}
