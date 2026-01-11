using OpenEPAYT.Network.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Pipe
    {
        public Pipe(Node startNode, Node endNode)
        {
            ID = "P1";
            Length = 100.0;
            Diameter = 12.0;
            Roughness = 100.0;
            MinorLoss = 0.0;
            Status = PipeStatusType.Open;
            Node1 = startNode;
            Node2 = endNode;
        }


        public string ID { get; set; }
        public Node Node1 {  get; set; }
        public Node Node2 { get; set; } 
        public double Length { get; set; }
        public double Diameter { get; set; }    
        public double Roughness { get; set; }
        public double MinorLoss { get; set; }   
        public PipeStatusType Status { get; set; }

        public string ExportItemSection()
        {
            string TextTemplate = $"{ID} {Node1.ID} {Node2.ID} {Length} {Diameter} {Roughness} {MinorLoss} {Status}";
            return TextTemplate;
        }
    }
}
