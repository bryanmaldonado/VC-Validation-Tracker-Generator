using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public bool? pm_exists { get; set; }
        public string? pm_enet_node { get; set; }
        public string? pm_enet_port { get; set; }

        public STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz(string? component = "STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz", string? type = "PDP", string? name = null, string? enet_node = null, string? enet_port = null, bool? pm_exists = null, string? pm_enet_node = null, string? pm_enet_port = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
            this.pm_exists = pm_exists;
            this.pm_enet_node = pm_enet_node;
            this.pm_enet_port = pm_enet_port;
        }
    }
}
