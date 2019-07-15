using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            string url2 = "http://www.google.com";
            WebInfoFactory webInfoList = new WebInfoFactory();
            Console.WriteLine(webInfoList.CreateWebInfo(url).ToString());
            Console.WriteLine(webInfoList.CreateWebInfo(url2).ToString());
            Console.WriteLine(webInfoList.CreateWebInfo(url).ToString());

        } 
    }
}
