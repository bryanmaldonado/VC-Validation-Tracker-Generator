using System.Reflection;
using VC_Validation_Tracker_Generator.XMLTemplates;
using System.Xml.Linq;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;

namespace VC_Validation_Tracker_Generator.Classes
{
    internal class Configuration
    {
        public string[,] data = new string[250, 17];
        public string[] configs = new string[17];
        public int numberOfItems = 0;
        public Object? resource;

        public Configuration(string[,] data, string[] configs, Object resource, int numberOfItems)
        {
            this.data = data;
            this.configs = configs;
            this.resource = resource;
            this.numberOfItems = numberOfItems;

        }

        public Object[] CreateResources()
        {
            Object[] resources = new Object[numberOfItems];
            for (int i = 0; i < this.numberOfItems; i++)
            {
                Debug.WriteLine(this.data[0, i]);
                if (this.data[i, 0] != "")
                {
                    string[] filldata = [this.data[i, 0], this.data[i, 1], this.data[i, 2], this.data[i, 3], this.data[i, 4], this.data[i, 5], this.data[i, 6], this.data[i, 7], this.data[i, 8], this.data[i, 9],
                        this.data[i, 10], this.data[i, 11], this.data[i, 12], this.data[i, 13], this.data[i, 14], this.data[i, 15], this.data[i, 16]];

                    resources[i] = FillResourceData(filldata, configs, resource);

                }
                else
                {
                    break;
                }
            }

            return resources;
        }

        public Object? FillResourceData(string[] data, string[] configs, Object resource)
        {

            Type resource_type = resource.GetType();
            PropertyInfo[] properties = resource_type.GetProperties();

            switch (resource)
            {
                #region EIP

                #region:STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC
                case STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC:

                    STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC template1 = new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC(
                        name: data[2],
                        module_name: data[2],
                        plc_robot_name: data[2],
                        enet_node_std: data[3],
                        enet_node_safe: data[3],
                        enet_port: data[4]
                        );

                    return template1;
                #endregion

                #region:STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL
                case STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL:

                    STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL template2 = new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL(
                        name: data[2],
                        module_name: data[2],
                        plc_robot_name: data[2]
                    );

                    template2.SetOptions( data[4] );
                    return template2;
                #endregion

                #region:STELLANTIS_EIP_WATER_SAVER
                case STELLANTIS_EIP_WATER_SAVER:

                    STELLANTIS_EIP_WATER_SAVER template3 = new STELLANTIS_EIP_WATER_SAVER(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template3;
                #endregion

                #region:STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX
                case STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX:
                    bool plc_controlled = false;
                    if (data[4] == "Y")
                    {
                        plc_controlled = true;
                    }

                    STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX template4 = new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX(
                        name: data[0],
                        module_name: data[0],
                        plc_robot_name: data[0],
                        zone_name: data[3],
                        plc_control: plc_controlled
                        );

                    return template4;
                #endregion

                #region:STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT
                case STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT:
                    Debug.WriteLine(data[0]);
                    STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT template5 = new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT(
                        name: data[0],
                        plc_robot_name: data[2],
                        switch1_name: "1PP1"
                        );

                    return template5;
                #endregion

                #region:STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz
                case STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz:

                    STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz template6 = new STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        out_pwr_source: data[4]
                        );

                    return template6;
                #endregion

                #region:STELLANTIS_EIP_HIRSCHMANN_ETHERNET_SWITCH_Sxx_SyyESWz
                case STELLANTIS_EIP_HIRSCHMANN_ETHERNET_SWITCH_Sxx_SyyESWz:

                    STELLANTIS_EIP_HIRSCHMANN_ETHERNET_SWITCH_Sxx_SyyESWz template7 = new STELLANTIS_EIP_HIRSCHMANN_ETHERNET_SWITCH_Sxx_SyyESWz(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template7;
                #endregion

                #region:STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_8IN_8OUT
                case STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_8IN_8OUT:

                    STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_8IN_8OUT template8 = new STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_8IN_8OUT(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template8;
                #endregion

                #region:STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_16IN
                case STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_16IN:

                    STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_16IN template9 = new STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_16IN(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template9;
                #endregion

                #region:STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy
                case STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy:

                    STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy template10 = new STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy(
                        name: data[0],
                        module_name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template10;
                #endregion

                #region:STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb
                case STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb:

                    STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb template11 = new STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb(
                        name: data[0],
                        remote_cell: data[0],
                        safety_zone: data[2]
                        );

                    return template11;
                #endregion

                #region:STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz
                case STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz:

                    STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz template12 = new STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz(
                        name: data[0],
                        enet_node_io: data[2],
                        enet_node_hmi: data[8]
                        );

                    return template12;
                #endregion

                #region:STELLANTIS_EIP_MAIN_CONTROL_PANEL
                case STELLANTIS_EIP_MAIN_CONTROL_PANEL:

                    STELLANTIS_EIP_MAIN_CONTROL_PANEL template13 = new STELLANTIS_EIP_MAIN_CONTROL_PANEL(
                        name: data[0],
                        slot2_switch_node: data[2],
                        slot2_switch_port: data[3]
                        );

                    return template13;
                #endregion

                #region:STELLANTIS_EIP_INTERFACE_BOX_SxxIBy
                case STELLANTIS_EIP_INTERFACE_BOX_SxxIBy:

                    STELLANTIS_EIP_INTERFACE_BOX_SxxIBy template14 = new STELLANTIS_EIP_INTERFACE_BOX_SxxIBy(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        panel_reset_text: data[5],
                        remote_reset_text: data[6],
                        light_screen1_exists: data[7],
                        light_screen2_exists: data[8],
                        safety_mat1_exists: data[9],
                        safety_mat2_exists: data[10]
                        );

                    return template14;
                #endregion

                #region:STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz
                case STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz:

                    STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz template15 = new STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        remote_reset_text: data[5],
                        light_screen2_exists: data[6],
                        safety_mat1_exists: data[7],
                        load_assist1_exists: data[8],
                        load_assist2_exists: data[9],
                        safety_mat2_exists: data[10]
                        );

                    return template15;
                #endregion

                #region:STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz
                case STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz:

                    STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz template16 = new STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz(
                        name: data[0],
                        enet_port: data[3]
                        );

                    return template16;
                #endregion

                #region:STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy
                case STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy:

                    STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy template17 = new STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy(
                        name: data[0],
                        module_name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        pos1a_inputs: data[6],
                        pos1b_inputs: data[7],
                        pos2a_inputs: data[8],
                        pos2b_inputs: data[9]
                        );

                    return template17;
                #endregion

                #region:STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy
                case STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy:

                    STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy template18 = new STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3]
                        );

                    return template18;
                #endregion

                #region:STELLANTIS_EIP_2_ZONE_POWER_Sxx_SyyPSBy
                case STELLANTIS_EIP_2_ZONE_POWER_Sxx_SyyPSBy:

                    STELLANTIS_EIP_2_ZONE_POWER_Sxx_SyyPSBy template19 = new STELLANTIS_EIP_2_ZONE_POWER_Sxx_SyyPSBy(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        stack_light1: data[6],
                        stack_light2: data[8],
                        stack_light3: data[10],
                        stack_light4: data[12]
                        );

                    return template19;
                #endregion

                #region:STELLANTIS_EIP_4_ZONE_POWER_Sxx_SyyPSBy
                case STELLANTIS_EIP_4_ZONE_POWER_Sxx_SyyPSBy:

                    STELLANTIS_EIP_4_ZONE_POWER_Sxx_SyyPSBy template20 = new STELLANTIS_EIP_4_ZONE_POWER_Sxx_SyyPSBy(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        stack_light1: data[6],
                        stack_light2: data[8],
                        stack_light3: data[10],
                        stack_light4: data[12]
                        );

                    return template20;
                #endregion

                #region:STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy
                case STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy:

                    STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy template21 = new STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy(
                        name: data[0],
                        enet_node: data[2],
                        enet_port: data[3],
                        stack_light1: data[6],
                        stack_light2: data[8],
                        stack_light3: data[10],
                        stack_light4: data[12]
                        );

                    return template21;
                #endregion

                #endregion

                #region DNET

                #region:STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC
                case STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC:

                    STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC dnet_template1 = new STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC(
                        name: data[2],
                        plc_robot_name: data[2],
                        out_data_tag: data[2],
                        in_data_tag: data[2],
                        dnet_network: data[3],
                        dnet_node: data[5]
                    );

                    dnet_template1.SetOptions(data[10]);
                    return dnet_template1;
                #endregion

                #region:STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY
                case STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY:

                    STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY dnet_template2 = new STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY(
                        name: data[0],
                        plc_robot_name: data[0],
                        dnet_network: data[3],
                        dnet_node: data[5]
                    );

                    return dnet_template2;
                #endregion

                #endregion


                default:
                    return null;
            
            }

        }
    }
}
