using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public string? out_pwr_source { get; set; }
        public string? input_byte_size { get; set; }

        public STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz(string? component = "STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz", string? type = "Valve Manifold", string? name = null, string? enet_node = null, string? enet_port = null,
            string? out_pwr_source = null, string? input_byte_size = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = $"ENET_STAT_4thSYS_ID[{utilities.parseNode(enet_node)}]";
            this.enet_port = enet_port;
            this.out_pwr_source = out_pwr_source;
            this.input_byte_size = "10";
        }

    }
}
