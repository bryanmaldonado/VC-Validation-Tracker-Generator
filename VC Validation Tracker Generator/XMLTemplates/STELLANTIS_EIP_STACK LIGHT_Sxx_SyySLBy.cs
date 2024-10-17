using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public bool? stack_light1_exists { get; set; }
        public bool? stack_light2_exists { get; set; }
        public bool? stack_light3_exists { get; set; }
        public bool? stack_light4_exists { get; set; }

        public STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy(string? component = "STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy", string? type = "Power Supply Box", string? name = null, string? enet_node = null, string? enet_port = null, string? stack_light1 = null, string? stack_light2 = null, string? stack_light3 = null, string? stack_light4 = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
            this.stack_light1_exists = stack_light1 != null;
            this.stack_light2_exists = stack_light2 != null;
            this.stack_light3_exists = stack_light3 != null;
            this.stack_light4_exists = stack_light4 != null;
        }
    }
}
