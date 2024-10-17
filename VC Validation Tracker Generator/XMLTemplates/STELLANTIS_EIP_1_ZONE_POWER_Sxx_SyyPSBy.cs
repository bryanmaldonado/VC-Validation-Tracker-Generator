using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }

        public STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy(string? component = "STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy", string? type = "Power Supply Box", string? name = null, string? enet_node = null, string? enet_port = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
        }
    }
}
