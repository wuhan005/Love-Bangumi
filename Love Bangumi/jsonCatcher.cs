using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Love_Bangumi
{
    class jsonCatcher
    {
        private string orginalJson;    //The orginal Json.
        private JObject jsonDecoder = new JObject(); //The json which was decoded.

        public jsonCatcher(string apiURL,Boolean needEdit = false)
        {
            orginalJson = link(apiURL); //Get the json from the Internet.

            if (needEdit == true)   //If get the single bangumi infomation, bilibili will add a prefix & a suffix randomly.
            {

                orginalJson = orginalJson.Replace("seasonListCallback(", "");
                orginalJson = orginalJson.Replace("jsonCallback(", "");
                orginalJson = orginalJson.Replace("callback(", "");
                orginalJson = orginalJson.Replace(");", "");
                orginalJson = orginalJson.Replace(")", "");

            }
                jsonDecoder = JObject.Parse(orginalJson);   //Decode.
            
        }
        public JObject json()
        {
            return jsonDecoder;
        }

        //  link:used to GET the api. Back with a String.
        private string link(string url)
        {
            WebClient webConn = new WebClient();
            webConn.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            // Add a user agent header 
            Stream data = webConn.OpenRead(url);
            StreamReader reader = new StreamReader(data, Encoding.UTF8);
            string backValue = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return backValue;
        }
    }
}
