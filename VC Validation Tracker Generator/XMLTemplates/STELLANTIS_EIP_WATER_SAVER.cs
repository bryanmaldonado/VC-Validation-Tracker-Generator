using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_WATER_SAVER
    {

        Utilities utilities = new Utilities();

        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }

        public STELLANTIS_EIP_WATER_SAVER(string? name = null, string? enet_node = null, string? enet_port = null, string? component = "STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL", string? type = "Robot")
        {
            this.component = name;
            this.type = type;
            this.name = name;
            this.enet_node = $"ENET_STAT_4thSYS_ID[{utilities.parseNode(enet_node)}]";
            this.enet_port = enet_port;
        }

    }
}
