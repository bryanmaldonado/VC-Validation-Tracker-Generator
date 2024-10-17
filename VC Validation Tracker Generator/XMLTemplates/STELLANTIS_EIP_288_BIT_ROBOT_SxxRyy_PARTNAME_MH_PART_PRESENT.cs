using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT
    {
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? plc_robot_name { get; set; }
        public string? switch_description { get; set; }
        public bool? switch1_exists { get; set; }
        public string? switch1_name { get; set; }
        public string? switch1_input { get; set; }
        public bool? switch2_exists { get; set; }
        public string? switch2_name { get; set; }
        public string? switch2_input { get; set; }

        public STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT(string? name = null, string? component = "STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT", string? type = "MH Swtich", string? plc_robot_name = null, string? switch_description = null,
            string? switch1_exists = null, string? switch1_name = null, string? switch1_input = null, string? switch2_exists = null, string? switch2_name = null, string? switch2_input = null)
        {
            string[] result = new string[2];
            string partName = string.Empty;
            if (name != null)
            {
                result = name.Split(':');
                partName = result[1];

            }

            this.component = component;
            this.type = type;
            this.name = name;
            this.plc_robot_name = plc_robot_name;
            this.switch_description = partName;
            this.switch1_exists = switch1_name != null ? true : false;
            this.switch1_name = "1PP1";
            this.switch1_input = $"{plc_robot_name}.I.b110";
            this.switch2_exists = switch2_name != null ? true : false;
            this.switch2_name = "1PP2";
            this.switch2_input = $"{plc_robot_name}.I.b111";
        }
    }
}
