using OpenEPAYT.Network.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Valve : Node
    {
        public Valve(Node startNode, Node endNode)
        {
            ID = "V1";
            Diameter = 100;
            Node1 = startNode;  
            Node2 = endNode;
        }
        public Node Node1 {  get; set; }    
        public Node Node2 {  get; set; }    
        public double Diameter {  get; set; }   
        public ValveType ValveType {  get; set; }
        public double Setting {  get; set; }
        public double MinorLoss {  get; set; }
        public override string ExportItemSection()
        {
            throw new NotImplementedException();
        }
    }
}
