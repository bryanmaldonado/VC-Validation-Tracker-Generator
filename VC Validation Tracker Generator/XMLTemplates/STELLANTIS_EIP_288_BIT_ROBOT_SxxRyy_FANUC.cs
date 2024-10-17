using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    public class STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? module_name { get; set; }
        public string? plc_robot_name { get; set; }
        public string? enet_note_std { get; set; }
        public string? enet_node_safe { get; set; }
        public string? enet_port { get; set; }

        public STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC(string? component = "STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC", string? type = "Robot", string? name = null, string? module_name = null, string? plc_robot_name = null, string? enet_node_std = null, string? enet_node_safe = null, string? enet_port = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.module_name = module_name;
            this.plc_robot_name = plc_robot_name;
            this.enet_note_std = $"ENET_STAT_1stSYS_ID[{utilities.parseNodes(enet_node_std)[0]}]";
            this.enet_node_safe = $"ENET_STAT_1stSYS_ID[{utilities.parseNodes(enet_node_std)[1]}]";
            this.enet_port = enet_port;
        }

    }
}
 