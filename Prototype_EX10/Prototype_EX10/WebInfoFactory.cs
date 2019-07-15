using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_EX10
{
    class WebInfoFactory
    {
        public Dictionary<string, WebInfo> webInfoList = new Dictionary<string, WebInfo>();

        public WebInfo CreateWebInfo(string urlToAdd)
        {
            if(!webInfoList.ContainsKey(urlToAdd))
            {
                webInfoList.Add(urlToAdd, new WebInfo(DateTime.Now, WriteWebRequestSizeAsync(urlToAdd), urlToAdd));
            }
            return webInfoList[urlToAdd].clone();
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        private static string WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    webRequest.GetResponseAsync().Result;
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        reader.ReadToEndAsync().Result;
                    Console.WriteLine(
                        FormatBytes(text.Length));
                    return FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }

            return "Failed...";
        }
    }
}
