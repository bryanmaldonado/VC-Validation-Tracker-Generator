using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY
    {
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? plc_robot_name { get; set; }
        public string? module_name { get; set; }
        public string? dnet_network { get; set; }
        public string? dnet_node { get; set; }

        public STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY(string? component = "STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY", string? type = "Robot", string? name = null, string? plc_robot_name = null, string? module_name = null, string? dnet_network = null, string? dnet_node = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.plc_robot_name = plc_robot_name;
            this.module_name = $"DNS{dnet_network}N{dnet_node}";
            this.dnet_network = dnet_network;
            this.dnet_node = dnet_node;
        }
    }
}
