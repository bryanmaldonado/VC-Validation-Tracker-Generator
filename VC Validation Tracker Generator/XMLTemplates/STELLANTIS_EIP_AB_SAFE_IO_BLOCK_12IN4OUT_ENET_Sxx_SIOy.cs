using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? module_name { get; set; }
        public string? module_type { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }

        public STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy(string? component = "STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy", string? type = "Ethernet Switch", string? name = null, string? module_name = null, string? module_type = "1732ES-IB12XOBV2", string? enet_node = null, string? enet_port = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.module_name = module_name;
            this.module_type = module_type;
            this.enet_node = $"ENET_STAT_4thSYS_ID[{utilities.parseNode(enet_node)}]";
            this.enet_port = enet_port;
        }
    }
}
