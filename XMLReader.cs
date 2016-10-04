using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XMLTest
{
    class XMLReader
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\amlee\\Desktop\\XML_FF.xml");
            //XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("/install/program");
            //Console.WriteLine(xmlDoc.DocumentElement.OuterXml);
            XmlNode root = xmlDoc.FirstChild;
            XmlNode elm = root, prev = root;
            Node xmlNode = new Node();
            List<string> xmlNode_list = new List<string>();
            int i = 0, j = 1;
            //Console.WriteLine(elm);
           if (root.HasChildNodes)
            {
                while (i < elm.ChildNodes.Count)
                {
                    Console.WriteLine("Number of Childs: {1}" + "{0}Name of ChildNode: {2}", Environment.NewLine, elm.ChildNodes.Count, elm.ChildNodes[i].Name);

                    elm = elm.ChildNodes[i];

                    if ( elm.ChildNodes.Count > 0 )
                    {
                        i = 0;
                    }

                    else if (elm.NextSibling != null){
                        elm = elm.NextSibling;
                    }

                    else
                    {
                        xmlNode_list.Add(elm.InnerText);
                        Console.WriteLine("InnerText: {1} {0}", Environment.NewLine, elm.InnerText);
                        if (prev.NextSibling != null)
                        {
                            elm = prev.NextSibling;
                            i = 0;
                        }
                        else
                        {
                            if (elm != root)
                            {
                                elm = elm.ParentNode;
                                i++;
                            }
                        }
                    }

                    Console.WriteLine("{1} {0}", Environment.NewLine, elm.Name);

                    prev = elm;
                }
            }
        }
    }

    public class Node
    {
        public String Elm_Name;
        public Char Type;
        public String Data;
        public Node()
        {
            Elm_Name = " ";
            Type = ' ';
            Data = " ";
        }
    }
}
