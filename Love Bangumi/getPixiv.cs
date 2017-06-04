using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love_Bangumi
{
    class getPixiv
    {
        private string bangumiName;
        private jsonCatcher getPicJson;

        private ArrayList backValue = new ArrayList();  //Used to save the pixiv ID.

        public getPixiv(string name)
        {
            //Filter the great pictures.
            bangumiName = name;

            //10000 stars
            getPicJson = new jsonCatcher("https://app-api.pixiv.net/v1/search/illust?word=" + name + " 10000users入り");
            addPictureID();

            //5000 stars
            getPicJson = new jsonCatcher("https://app-api.pixiv.net/v1/search/illust?word=" + name + " 5000users入り");
            addPictureID();

            //1000 stars
            getPicJson = new jsonCatcher("https://app-api.pixiv.net/v1/search/illust?word=" + name + " 1000users入り");
            addPictureID();

            //500 stars
            getPicJson = new jsonCatcher("https://app-api.pixiv.net/v1/search/illust?word=" + name + " 500users入り");
            addPictureID();
        }

        private void addPictureID()
        {
            if (getPicJson.json()["illusts"].LongCount() != 0)
            {
                for (int i = 0; i < getPicJson.json()["illusts"].LongCount(); i++)
                {
                    backValue.Add((string)getPicJson.json()["illusts"][i]["id"]);
                }
            }
        }

        public ArrayList pic()
        {
            return backValue;
        }
    }
}
