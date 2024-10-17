using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using VC_Validation_Tracker_Generator.Classes;
using VC_Validation_Tracker_Generator.XMLTemplates;
using Path = System.IO.Path;

namespace VC_Validation_Tracker_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XMLConstructor xmlConstructor = new XMLConstructor();
        Utilities utilities = new Utilities();

        string[]? files;
        string fileSavePath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            fileSavePath = save_file_path.Text;
        }

        private void generate_xml_btn_Click(object sender, RoutedEventArgs e)
        {
            Configuration[]? configs;
            //Fetch Files in Headers  Path
            files = utilities.FetchFiles(header_path_search, logger);

            //Extract Data From Files
            if (files != null)
            {
                utilities.LogAppender(logger, "Extracting data from header files..");
                configs = utilities.DataExtraction(files);
                foreach (Configuration config in configs)
                {
                    if (config is not null)
                    {
                        Object[] resources = config.CreateResources();
                        xmlConstructor.XMLGenerateFile(resources);
                    }
                }

            }

            //Save XML
            xmlConstructor.XMLSaveFile(fileSavePath);
            utilities.LogAppender(logger, $"File was generated successfully at {fileSavePath}.");
        }

        private void header_path_search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void header_path_search_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void save_path_btn_Click(object sender, RoutedEventArgs e)
        {
            fileSavePath = utilities.GetFilePathSaved();
        }
    }
}