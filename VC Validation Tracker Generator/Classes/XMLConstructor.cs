using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace VC_Validation_Tracker_Generator.Classes
{
    internal class XMLConstructor
    {
        XElement srcTree;
        public XMLConstructor()
        {
            this.srcTree = new XElement("validationtracker");
        }
        public void XMLGenerateFile(Object[] resources)
        {
            foreach (Object resource in resources)
            {
                if (resource is not null)
                {
                    XMLAppendNode(XMLBuildNode(resource));
                }
            }
        }

        public void XMLSaveFile(string filePath)
        {
            //Append nodes to root and save file
            Debug.WriteLine(filePath);
            new XDocument(srcTree).Save(filePath);
        }

        public void XMLAppendNode(XElement node)
        {
            srcTree.Add(node);
        }

        public XElement XMLBuildNode(Object resource)
        {
            XElement nodeRoot = new XElement("trackeritem");
            Type type = resource.GetType();
            PropertyInfo[] properties = type.GetProperties();


            foreach (PropertyInfo property in properties)
            {
                // Get the value of the property
                var value = property.GetValue(resource);
                nodeRoot.Add(new XElement(property.Name, value));
            }
            return nodeRoot;
        }
    }
}
