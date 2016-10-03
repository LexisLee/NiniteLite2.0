using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Pull_HTML_test
{
    class Program
    {

        public static void Download_Exe(string url)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile(new Uri(url), "C:\\Users\\gbortiz\\Downloads\\FF.exe");
        }

        public static void Download_Page(string url)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile(new Uri(url), "C:\\Users\\gbortiz\\html.txt");
        }

        static void Main(string[] args)
        {
            Download_Page("https://www.mozilla.org/en-US/firefox/all/");

            using (StreamReader sr = new StreamReader("C:\\Users\\gbortiz\\html.txt"))
            {
                String line = sr.ReadToEnd();
                int temp = line.IndexOf("class=\"download win64\"");
                Console.WriteLine(temp);
                line = line.Substring(temp);
                temp = line.IndexOf("en-US");
                Console.WriteLine(temp);
                line = line.Substring(temp);
                temp = line.IndexOf("class=\"download win64\"");
                Console.WriteLine(temp);
                line = line.Substring(temp);
                Match m = Regex.Match(line, @"href=""[^""\\]*(?:\\.[^""\\]*)*""");
                line = m.ToString();
                m = Regex.Match(line, @"http.*");
                line = m.ToString();
                line = line.Trim('"');
                Console.WriteLine(line);
                Download_Exe(line);
            }
        }
    }
}
