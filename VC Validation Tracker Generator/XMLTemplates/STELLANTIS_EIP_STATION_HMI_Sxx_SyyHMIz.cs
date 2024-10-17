using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node_io { get; set; }
        public string? enet_node_hmi { get; set; }
        public bool? sec_reset1 { get; set; }
        public string? sec_reset1_text { get; set; }
        public bool? sec_reset2 { get; set; }
        public string? sec_reset2_text { get; set; }
        public bool? light_screen { get; set; }
        public string? light_screen_text { get; set; }

        public STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz(string? component = "STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz", string? type = "HMI Panel", string? name = null, string? enet_node_io = null, string? enet_node_hmi = null, bool? sec_reset1 = null, string? sec_reset1_text = null, bool? sec_reset2 = null, string? sec_reset2_text = null, bool? light_screen = null, string? light_screen_text = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node_io = utilities.parseNode(enet_node_io);
            this.enet_node_hmi = utilities.parseNode(enet_node_hmi);
            this.sec_reset1 = sec_reset1;
            this.sec_reset1_text = sec_reset1_text;
            this.sec_reset2 = sec_reset2;
            this.sec_reset2_text = sec_reset2_text;
            this.light_screen = light_screen;
            this.light_screen_text = light_screen_text;
        }
    }
}
