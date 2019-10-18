using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Classes
{
    public class Portal
    {
        public string name { get; set; }
        public string host { get; set; }
        public string description { get; set; }
        public string bannerImage { get; set; } = "https://portal.limeinst.com/css/images/logo.png";
        public string logo { get; set; } = "https://portal.limeinst.com/css/images/logo.png";
        public string background { get; set; } = "linear-gradient(to right, #333 0%, #333 100%);";
        public List<string> tags { get; set; }
    }
}

