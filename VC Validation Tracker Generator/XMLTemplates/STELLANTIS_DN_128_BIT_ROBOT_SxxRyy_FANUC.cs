using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Validation_Tracker_Generator.XMLTemplates
{
    internal class STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC
    {
        public string? component { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? plc_robot_name { get; set; }
        public string? out_data_tag { get; set; }
        public string? in_data_tag { get; set; }
        public string? dnet_network { get; set; }
        public string? dnet_node{ get; set; }
        public bool app_mh { get; set; }
        public bool? proc1_exists { get; set; }
        public bool? proc2_exists { get; set; }
        public bool? proc1_spot { get; set; }
        public bool? proc2_spot { get; set; }
        public bool? proc_stud { get; set; }
        public bool? proc1_disp { get; set; }
        public bool? proc2_disp { get; set; }


        public STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC(string? out_data_tag = null, string? in_data_tag = null, string? dnet_network = null, string? dnet_node = null, string? name = null, string? plc_robot_name = null, bool? app_mh = null, bool? proc1_exists = null,
            bool? proc2_exists = null, bool? proc1_spot = null, bool? proc2_spot = null, bool? proc_stud = null, bool? proc1_disp = null, bool? proc2_disp = null, string? component = "STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC", string? type = "Robot")
        {
            this.component = component;
            this.type = type;
            this.name = name;
            this.plc_robot_name = plc_robot_name;
            this.out_data_tag = $"ENBT{dnet_network}:1:O.Data[{Convert.ToInt32(dnet_node) + 31}]";
            this.in_data_tag = $"ENBT{dnet_network}:1:I.Data[{Convert.ToInt32(dnet_node) + 31}]";
            this.dnet_network = dnet_network;
            this.dnet_node = dnet_node;
        }

        public void SetOptions(string data)
        {
            string input = data;
            string[] result = input.Split(';');
            int length = result.Length;

            if (result[length - 1] == "")
            {
                length--;
            }

            //result = result.Where(s => !s.StartsWith("")).ToArray();
            proc1_exists = length > 1 ? true : false;

            if (length > 2 || length > 1 && !app_mh)
            {
                proc2_exists = true;
            }

            // Iterate through the result array to see the individual options
            foreach (string item in result)
            {
                switch (item)
                {
                    case "MH":
                        app_mh = true;
                        break;
                    case "SPOT1":
                        proc1_spot = true;
                        break;
                    case "SPOT2":
                        proc2_spot = true;
                        break;
                    case "STUD":
                        proc_stud = true;
                        break;
                    case "DISP1":
                        proc1_disp = true;
                        break;
                    case "DISP2":
                        proc2_disp = true;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
