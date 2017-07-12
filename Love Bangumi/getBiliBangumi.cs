using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Love_Bangumi;
using System.Collections.Generic;

//Mashiro Maji Tenshi!!

public class getBiliBangumi
{
    private uint bangumiSeasonId;
    private jsonCatcher bangumiJson;

    private Dictionary<string, string> bangumiInfo = new Dictionary<string, string>();

    private string bName;
    private string bJpName;     //Bangumi's Japanese Name.
    private string bPicture;
    private string bIsFinish;
    private string bCount;
    private string bDetail;
    private string bURL;    //just the bilibili URL.
    private string bID;     //season_id, used to search the bangumi.

    JToken bEpisodes;   //Back the episodes as the original json.

    public getBiliBangumi(uint id)
	{
        bangumiSeasonId = id;
        bangumiJson = new jsonCatcher("http://bangumi.bilibili.com/jsonp/seasoninfo/" + bangumiSeasonId.ToString() + ".ver?callback=seasonListCallback&jsonp=jsonp&_=1493791405048", true);

        if ((int)bangumiJson.json()["code"] == 0)
        {
            bName = (string)bangumiJson.json()["result"]["bangumi_title"];
            bJpName = (string)bangumiJson.json()["result"]["jp_title"];
            bPicture = (string)bangumiJson.json()["result"]["cover"];
            bIsFinish = (string)bangumiJson.json()["result"]["is_finish"];
            bCount = (string)bangumiJson.json()["result"]["total_count"];
            bDetail = (string)bangumiJson.json()["result"]["evaluate"];
            bURL = (string)bangumiJson.json()["result"]["share_url"];
            bID = (string)bangumiJson.json()["result"]["season_id"];
            bEpisodes = bangumiJson.json()["result"]["episodes"];

            bangumiInfo.Add("Name", bName);
            bangumiInfo.Add("JapanName", bJpName);
            bangumiInfo.Add("Picture", bPicture);
            bangumiInfo.Add("IsFinish", bIsFinish);
            bangumiInfo.Add("Count", bCount);
            bangumiInfo.Add("Detail", bDetail);
            bangumiInfo.Add("URL", bURL);
            bangumiInfo.Add("ID", bID);
        }
        else
        {
            MessageBox.Show("无法从Bilibili拉取番剧数据！");
        }
    }

    public Dictionary<string,string> data()
    {
        return bangumiInfo;
    }

    public JToken episodes()
    {
        return bEpisodes;
    }
}
