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
            xmlDoc.Load("C:\\Users\\gbortiz\\Desktop\\XML_FF.xml");
            //XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("/install/program");
            //Console.WriteLine(xmlDoc.DocumentElement.OuterXml);
            XmlNode root = xmlDoc.FirstChild;
            XmlNode elm = root;
            Node xmlNode = new Node();
            List<Node> xmlNode_list = new List<Node>();
            //Console.WriteLine(elm);
            if (root.HasChildNodes)
             {
                 for (int i = 0; i < elm.ChildNodes.Count; i++)
                 {
                    Console.WriteLine(i);
                    Console.WriteLine(elm.ChildNodes.Count);
                    xmlNode.Elm_Name = elm.ChildNodes[i].Name;
                    xmlNode.Data = elm.ChildNodes[i].InnerText;
                    Console.WriteLine(xmlNode.Elm_Name);
                    Console.WriteLine(": ");
                    Console.WriteLine(xmlNode.Data);
                    Console.WriteLine();
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
