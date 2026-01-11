using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Junction : Node
    {
        public Junction()
        {
            ID = "J1";
            Elevation = 0.0;
            Pattern = string.Empty;
        }
        public double Demand { get; set; }  

        public override string ExportItemSection()
        {
            string TextTemplate = $"{ID} {Elevation} {Demand} {Pattern}";
            return TextTemplate;
        }
    }
}
