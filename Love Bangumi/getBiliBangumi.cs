using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Love_Bangumi;

//Mashiro Maji Tenshi!!

public class getBiliBangumi
{
    private static uint biliID = 3788683;   //User's Bilibili ID. Pay attation this is a UINT!!!
    private jsonCatcher recentBangumiJson;

    public getBiliBangumi()
	{
        recentBangumiJson = new jsonCatcher("http://space.bilibili.com/ajax/Bangumi/getList?mid=" + biliID.ToString() + "&page=1");
        
        if ((string)recentBangumiJson.json()["status"] == "True")    //True is connect OK, not "true". Pay attation!!
        {
            
        }
        else
        {
            MessageBox.Show("无法从Bilibili拉取数据！");
        }
    }

    public string[] recentBangumi()
    {
        string bName = (string)recentBangumiJson.json()["data"]["result"][0]["title"];
        string bPicture = (string)recentBangumiJson.json()["data"]["result"][0]["cover"];
        string bIsFinish = (string)recentBangumiJson.json()["data"]["result"][0]["is_finish"]; 
        string bCount = (string)recentBangumiJson.json()["data"]["result"][0]["total_count"];
        string bURL = (string)recentBangumiJson.json()["data"]["result"][0]["share_url"];
        string bID = (string)recentBangumiJson.json()["data"]["result"][0]["season_id"];

        string[] bangumiInfo = { bName, bPicture, bIsFinish, bCount, bURL, bID};
        return bangumiInfo;
    }
}
