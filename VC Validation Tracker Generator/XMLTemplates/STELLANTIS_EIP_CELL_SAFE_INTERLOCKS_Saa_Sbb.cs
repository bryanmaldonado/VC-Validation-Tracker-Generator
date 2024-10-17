using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb
    {
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? remote_cell { get; set; }
        public string? consumed_tag { get; set; }
        public string? safety_zone { get; set; }

        public STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb(string? component = "STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb", string? type = "Interlocks", string? name = null, string? remote_cell = null, string? consumed_tag = null, string? safety_zone = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.remote_cell = remote_cell;
            this.consumed_tag = $"Consumer_{name}_S";
            this.safety_zone = safety_zone;
        }
    }
}
