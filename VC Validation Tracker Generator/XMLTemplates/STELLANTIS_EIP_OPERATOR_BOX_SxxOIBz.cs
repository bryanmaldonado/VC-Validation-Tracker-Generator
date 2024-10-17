using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public bool? remote_reset_exists { get; set; }
        public string? remote_reset_text { get; set; }
        public bool? light_screen2_exists { get; set; }
        public bool? safety_mat1_exists { get; set; }
        public bool? load_assist1_exists { get; set; }
        public bool? load_assist2_exists { get; set; }
        public bool? safety_mat2_exists { get; set; }
        public bool? operator2_exists { get; set; }

        public STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz(string? component = "STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz", string? type = "Operator Interface Box", string? name = null, string? enet_node = null, string? enet_port = null, string? remote_reset_exists = null, string? remote_reset_text = null, string? light_screen2_exists = null, string? safety_mat1_exists = null, string? load_assist1_exists = null, string? load_assist2_exists = null, string? safety_mat2_exists = null, string? operator2_exists = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
            this.remote_reset_exists = remote_reset_text != null ? true : false;
            this.remote_reset_text = remote_reset_text;
            this.light_screen2_exists = light_screen2_exists == "Y" ? true : false;
            this.safety_mat1_exists = safety_mat1_exists == "Y" ? true : false;
            this.load_assist1_exists = load_assist1_exists == "Y" ? true : false;
            this.load_assist2_exists = load_assist2_exists == "Y" ? true : false;
            this.safety_mat2_exists = safety_mat2_exists == "Y" ? true : false;
            this.operator2_exists = operator2_exists == "Y" ? true : false;
        }
    }
}
