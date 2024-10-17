using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_INTERFACE_BOX_SxxIBy
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public string? module_name { get; set; }
        public string? panel_reset_text { get; set; }
        public string? remote_reset_text { get; set; }
        public bool? light_screen1_exists { get; set; }
        public bool? light_screen2_exists { get; set; }
        public bool? safety_mat1_exists { get; set; }
        public bool? safety_mat2_exists { get; set; }

        public STELLANTIS_EIP_INTERFACE_BOX_SxxIBy(string? name = null, string? enet_node = null, string? enet_port = null, string? module_name = null, string? panel_reset_text = null, string? remote_reset_text = null, string? light_screen1_exists = null, string? light_screen2_exists = null, string? safety_mat1_exists = null, string? safety_mat2_exists = null, string? component = "STELLANTIS_EIP_INTERFACE_BOX_SxxIBy", string? type = "Interface Box")
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
            this.module_name = module_name;
            this.panel_reset_text = panel_reset_text;
            this.remote_reset_text = remote_reset_text;
            this.light_screen1_exists = light_screen1_exists == "Y" ? true : false;
            this.light_screen2_exists = light_screen2_exists == "Y" ? true : false;
            this.safety_mat1_exists = safety_mat1_exists == "Y" ? true : false;
            this.safety_mat2_exists = safety_mat2_exists == "Y" ? true : false;
        }
    }
}
