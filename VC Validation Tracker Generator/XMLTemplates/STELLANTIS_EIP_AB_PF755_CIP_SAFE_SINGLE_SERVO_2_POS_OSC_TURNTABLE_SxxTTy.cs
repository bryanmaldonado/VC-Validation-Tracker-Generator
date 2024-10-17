using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VC_Validation_Tracker_Generator.Classes;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy
    {
        Utilities utilities = new Utilities();
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? module_name { get; set; }
        public string? enet_node { get; set; }
        public string? enet_port { get; set; }
        public string? pos1a_inputs { get; set; }
        public string? pos1b_inputs { get; set; }
        public string? pos2a_inputs { get; set; }
        public string? pos2b_inputs { get; set; }

        public STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy(string? component = "STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy", string? type = "Turntable", string? name = null, string? module_name = null, string? enet_node = null, string? enet_port = null, string? pos1a_inputs = null, string? pos1b_inputs = null, string? pos2a_inputs = null, string? pos2b_inputs = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.module_name = $"{ module_name}_VFD";
            this.enet_node = utilities.parseNode(enet_node);
            this.enet_port = enet_port;
            this.pos1a_inputs = pos1a_inputs;
            this.pos1b_inputs = pos1b_inputs;
            this.pos2a_inputs = pos2a_inputs;
            this.pos2b_inputs = pos2b_inputs;
        }
    }
}
