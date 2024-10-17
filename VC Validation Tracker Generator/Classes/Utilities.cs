using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;
using Microsoft.Office.Interop.Excel;
using VC_Validation_Tracker_Generator.XMLTemplates;
using System.Diagnostics;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.ComponentModel;
using Microsoft.Win32;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using System.Net;

namespace VC_Validation_Tracker_Generator.Classes
{
    internal class Utilities
    {
        public string[] GetFilesInPath(string path)
        {
            int iterator = 0;

            //Returns an array of file paths
            string[] filePaths = Directory.GetFiles(@$"{path}", "Signal Header*.xlsm",
                                         SearchOption.TopDirectoryOnly);

            foreach (string filePath in filePaths)
            {
                
                iterator++;
            } 
            return filePaths;
        }

        public void LogAppender(TextBlock logger, string text)
        {
            //Register events
            string time = DateTime.Now.TimeOfDay.ToString();
            logger.Text += $"\n\n{time}: {text}";
        }

        public Configuration[] DataExtraction(string[] files)
        {
            //Temporary limit of 500 devices per simulation.
            Configuration[] resource_configurations = new Configuration[500];
            string[] fileNames = new string[500];
            int iterator = 0;

            //Create a resource_configuration for each header file.
            foreach (string file in files)
            {
                string connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=No;IMEX=1\";", file);
                OleDbConnection SQLConn = new OleDbConnection(connectionString);
                SQLConn.Open();
                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter();
                SQLAdapter.TableMappings.Add("Table", "Resource");

                string sql = "SELECT * FROM [" + "Header" + "$]";
                OleDbCommand selectCMD = new OleDbCommand(sql, SQLConn);
                SQLAdapter.SelectCommand = selectCMD;
                DataSet data = new DataSet("Resource");
                SQLAdapter.Fill(data);
                SQLConn.Close();

                fileNames[iterator] = Path.GetFileName(file);

                //Get ResourceType based on Header File Name.
                Object? resource = GetResourceType(fileNames[iterator]) is not null ? GetResourceType(fileNames[iterator]) : null;
                if (resource != null)
                {
                    resource_configurations[iterator] = TableReader(data, resource);
                }
                else
                {
                    Debug.WriteLine("Resource was null.");
                }

                //Read next file
                iterator++;
            }

            return resource_configurations;
        }

        public Configuration TableReader(DataSet data, Object resource_type)
        {
            string[,] values = new string[250, 17];
            string[] configs = new string[17];
            int iterator_i = 0;
            int iterator_j = 0;


            //Iterate over main data table to extract column names and values.
            for (int row_zero = 7; row_zero < 200; row_zero++)
            {
                string uniqueID = Convert.ToString(data.Tables[0].Rows[row_zero+1][4]);
                if (uniqueID != "")
                {
                    for (int col_zero = 4; col_zero <= 20; col_zero++)
                    {
                        string config = Convert.ToString(data.Tables[0].Rows[7][col_zero]);

                        if (!config.Contains("<Config"))
                        {
                            values[row_zero - 7, col_zero - 4] = Convert.ToString(data.Tables[0].Rows[row_zero + 1][col_zero]);

                            if (row_zero == 7)
                            {
                                configs[col_zero - 4] = config;
                            }

                        }
                        iterator_j++;
                    }
                }
                else
                {
                    Debug.WriteLine("Finished reading file.");
                    break;
                }
                iterator_i++;
            }

            return new Configuration(values, configs, resource_type, iterator_i);
        }

        public Object? GetResourceType(string file)
        {
            switch (file)
            {
                case "Signal Header - STELLANTIS - EIP - Common - Robots - 288 Bit - Base - Fanuc - v00.00.xlsm":
                    return new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC();
                case "Signal Header - STELLANTIS - EIP - Common - Robots - 288 Bit - Common - General - v00.00.xlsm":
                    return new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_GENERAL();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - WaterSaver - IO Block - Enet - v00.00.xlsm":
                    return new STELLANTIS_EIP_WATER_SAVER();
                case "Signal Header - STELLANTIS - EIP - Common - Robots - 288 Bit - Safety - Fanuc DCS Zone - v00.00.xlsm":
                    return new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_FANUC_DCS_ZONE_XX();
                case "Signal Header - STELLANTIS - EIP - Common - Robots - 288 Bit - Tooling - MH Part Present - v00.00.xlsm":
                    return new STELLANTIS_EIP_288_BIT_ROBOT_SxxRyy_PARTNAME_MH_PART_PRESENT();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - SMC - Valve Manifold - Enet - v00.00.xlsm":
                    return new STELLANTIS_EIP_VALVE_MANIFOLD_ENET_SxxFyyVMz();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - Hirschmann - Ethernet Switch - v00.00.xlsm":
                    return new STELLANTIS_EIP_HIRSCHMANN_ETHERNET_SWITCH_Sxx_SyyESWz();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - AB - Safe IO Block - Enet - 12in 4out - v00.00.xlsm":
                    return new STELLANTIS_EIP_AB_SAFE_IO_BLOCK_12IN4OUT_ENET_Sxx_SIOy();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - AB - IO Block - Enet - 16in - v00.00.xlsm":
                    return new STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_16IN();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - AB - IO Block - Enet - 8in 8out - v00.00.xlsm":
                    return new STELLANTIS_EIP_AB1732_IO_BLOCK_ENET_8IN_8OUT();
                case "Signal Header - STELLANTIS - DN - Common - Robots - 128 Bit - Common - Start - v00.00.xlsm":
                    return new STELLANTIS_DN_128_BIT_INTEGRATED_SAFETY_ROBOT_SxxRyy_FANUC_SAFETY();
                case "Signal Header - STELLANTIS - DN - Common - Robots - 128 Bit - Base - Fanuc - Integrated Safety - v00.00.xlsm":
                    return new STELLANTIS_DN_128_BIT_ROBOT_SxxRyy_FANUC();
                case "Signal Header - STELLANTIS - EIP - Common - Interlocks - Cell Safe Interlocks - v00.00.xlsm":
                    return new STELLANTIS_EIP_CELL_SAFE_INTERLOCKS_Saa_Sbb();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - HMI J-Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_STATION_HMI_Sxx_SyyHMIz();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - MCP - Main Control Panel - v00.00.xlsm":
                    return new STELLANTIS_EIP_MAIN_CONTROL_PANEL();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - IB - Interface Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_INTERFACE_BOX_SxxIBy();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - OIB - Operator Interface Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_OPERATOR_BOX_SxxOIBz();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - PDP - Power Distribution Panel - v00.00.xlsm":
                    return new STELLANTIS_EIP_DIST_PANEL_Sxx_SyyPDPz();
                case "Signal Header - STELLANTIS - EIP - Common - Devices - AB - PF755 CIP Safe Single Servo - Turntable - 2 Pos Oscillating - v00.00.xlsm":
                    return new STELLANTIS_EIP_AB_PF755_CIP_SAFE_SINGLE_SERVO_2_POS_OSC_TURNTABLE_SxxTTy();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - PSB - 1 Zone Power Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_1_ZONE_POWER_Sxx_SyyPSBy();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - PSB - 2 Zone Power Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_2_ZONE_POWER_Sxx_SyyPSBy();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - PSB - 4 Zone Power Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_4_ZONE_POWER_Sxx_SyyPSBy();
                case "Signal Header - STELLANTIS - EIP - Common - Panels - SLB - Stack Light Box - v00.00.xlsm":
                    return new STELLANTIS_EIP_STACK_LIGHT_Sxx_SyySLBy();
                default:
                    return null;
            }
        }

        public string TransformData(string value, string config)
        {
            string transformedData = string.Empty;
            switch (config)
            {
                default:
                    return value;
            }
        }

        public string[]? FetchFiles(System.Windows.Controls.TextBox searchbox, TextBlock logger)
        {
            //Get Header Files Directory
            string filePath = searchbox.Text;
            string[]? files = new string[100]; 


            //Retrieve files from directory
            if (filePath != string.Empty)
            {
                files = GetFilesInPath(filePath);

                //Log Action Result
                if (files is not null)
                {
                    if (files.Length >= 0)
                    {
                        LogAppender(logger, $"Files found: {files.Length}");
                    }
                    else
                    {
                        LogAppender(logger, $"No files found.");
                    }
                }
                else
                {
                    LogAppender(logger, $"Error with selected path.");
                }

            }

            return files;
        }

        public string GetFilePathSaved()
        {
            string path = string.Empty;

            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                path = saveFileDialog.FileName;
            }

            return path;
        }

        public string parseNode(string data)
        {
            string parsedNode = string.Empty;
            if (data != null)
            {
                parsedNode = data.Split(":")[1];
            }
            return parsedNode;
        }

        public string[] parseNodes(string data)
        {
            string[] nodes = new string[2];

            if (data != null)
            {
                string[] result = data.Split("|");
                for (int i = 0; i < result.Length; i++)
                {
                    nodes[i] = result[i].Split(":")[1];
                }

            }
            
            return nodes;
        }
    }
}
