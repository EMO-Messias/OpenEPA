using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Reservoir : Node
    {
        public double Head { get; set; }
        public override string ExportItemSection()
        {
           string TextTemplate = $"{ID} {Head} {Pattern}";
            return TextTemplate;    
        }
    }
}
