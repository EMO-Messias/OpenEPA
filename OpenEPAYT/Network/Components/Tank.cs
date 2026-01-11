using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Components
{
    public class Tank : Node
    {
        public double InitLevel { get; set; }
        public double MinLevel { get; set; }
        public double MaxLevel { get; set; }
        public double Diameter { get; set; }
        public double MinVol { get; set; }  
        public string VolCurve { get; set; }
        public override string ExportItemSection()
        {
            string TextTemplate = $"{ID} {Elevation} {InitLevel} {MinLevel} {MaxLevel} {Diameter} {MinVol} {VolCurve}";
            return TextTemplate;    
        }
    }
}
