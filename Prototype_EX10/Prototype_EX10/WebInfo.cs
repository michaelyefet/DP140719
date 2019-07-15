using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_EX10
{
    class WebInfo : IProtoType<WebInfo>
    {
        public DateTime Timestamp;
        public string size;
        public string url;

        public WebInfo(DateTime Timestamp, string size, string url)
        {
            this.Timestamp = Timestamp;
            this.size = size;
            this.url = url;
        }

        public override string ToString()
        {
            return $"Timestamp: {Timestamp} size: {size} url: {url}";
        }
        public WebInfo clone()
        {
            return new WebInfo(this.Timestamp, this.size, this.url);
        }
    }
}
