using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_MAIN_CONTROL_PANEL
    {

        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? slot2_switch_node { get; set; }
        public string? slot2_switch_port { get; set; }
        public bool? slot3_switch_connected { get; set; }
        public string? slot3_switch_node { get; set; }
        public string? slot3_switch_port { get; set; }
        public bool? slot4_switch_connected { get; set; }
        public string? slot4_switch_node { get; set; }
        public string? slot4_switch_port { get; set; }
        public bool? slot5_switch_connected { get; set; }
        public string? slot5_switch_node { get; set; }
        public string? slot5_switch_port { get; set; }
        public bool? slot6_switch_connected { get; set; }
        public string? slot6_switch_node { get; set; }
        public string? slot6_switch_port { get; set; }

        public STELLANTIS_EIP_MAIN_CONTROL_PANEL(string? component = "STELLANTIS_EIP_MAIN_CONTROL_PANEL", string? type = "Main Control Panel", string? name = null, string? slot2_switch_node = null, string? slot2_switch_port = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.slot2_switch_node = utilities.parseNode(slot2_switch_node);
            this.slot2_switch_port = slot2_switch_port;
        }
    }
}
