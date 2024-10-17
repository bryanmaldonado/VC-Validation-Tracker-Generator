using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX
    {
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? module_name { get; set; }
        public string? plc_robot_name { get; set; }
        public string? zone_name { get; set; }
        public bool? plc_control { get; set; }
        public bool? plc_disable { get; set; }

        public STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX(string? component = "STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX", string? type = "Robot", string? name = null, string? module_name = null, string? plc_robot_name = null, string? zone_name = null, bool? plc_control = null, bool? plc_disable = null)
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.module_name = module_name;
            this.plc_robot_name = plc_robot_name;
            this.zone_name = $"DCS0{zone_name}";
            this.plc_control = plc_control;
            this.plc_disable = !plc_control;
        }
    }
}
