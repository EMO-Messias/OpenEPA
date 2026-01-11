using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Pump
    {
        public Pump (Node startNode, Node endNode)
        {
            Node1 = startNode;
            Node2 = endNode;
        }

        public Node Node1 { get; set; }
        public Node Node2 {  get; set; }    
        public string Parameters { get; set; }  
    }
}
