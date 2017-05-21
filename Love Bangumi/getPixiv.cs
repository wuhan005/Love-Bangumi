using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_Bangumi
{
    class getPixiv
    {
        private string bangumiName;
        private jsonCatcher getPicJson;

        public getPixiv(string name)
        {
            bangumiName = name;
            getPicJson = new jsonCatcher("https://app-api.pixiv.net/v1/search/illust?word=" + name + "1000users入り");
        }
        public JObject pic()
        {

            return getPicJson.json();
        }
    }
}
