using OpenEPAYT.Network.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network
{
    public class Network
    {
        public Network()
        {
            Title = "Rede 1";
            Junctions = new List<Junction>();
            Pipes = new List<Pipe>();
            Reservoirs = new List<Reservoir>();
            Tanks = new List<Tank>();
            Pumps = new List<Pump>();
            Settings = new SimulationSettings();
        }

        public string Title { get; set; }
        public SimulationSettings Settings { get; set; }
        public List<Junction> Junctions { get; set; }
        public List<Pipe> Pipes { get; set; }
        public List<Reservoir> Reservoirs { get; set; }
        public List<Tank> Tanks { get; set; }
        public List<Pump> Pumps { get; set; }
    }
}
