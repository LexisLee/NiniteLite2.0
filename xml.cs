using System;
using System.Xml;
using System.IO;
namespace ReadXMLfromFile
{
    class Class1
    {

        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("C:\\Users\\mesa\\Desktop\\firefox.xml");
            while (reader.Read()) 
            {
                switch (reader.NodeType) 
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine (reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();
        }

        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

        static void try_catch()
        {
            string s = null; // For demonstration purposes.

            try
            {
                ProcessString(s);
            }

            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
